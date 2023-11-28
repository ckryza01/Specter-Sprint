using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    GameObject player;
    PlayerLife playerLifeScript;
    [SerializeField] float speed = 1f;
    [SerializeField] float attackRange = .25f;
    [SerializeField] float chaseRange = 10f;
    Animation animationComponent;

    private float initialYPosition;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerLifeScript = player.GetComponent<PlayerLife>();
        animationComponent = GetComponent<Animation>();
        if (animationComponent != null)
        {
            animationComponent.Play("Walk");
        }

        initialYPosition = transform.position.y;
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (playerLifeScript.IsInvincible() && distanceToPlayer <= attackRange) {
            Die();
        }
        else if (playerLifeScript.IsInvincible())
        {
            RunFromPlayer();
        }
        else if (distanceToPlayer <= attackRange)
        {
            AttackPlayer();
        }
        else if (distanceToPlayer <= chaseRange)
        {
            ChasePlayer();
        } 
        else
        {
            Destroy(gameObject);
        }

    }

    void ChasePlayer()
    {
        transform.LookAt(player.transform);
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    void RunFromPlayer()
    {
        Vector3 directionToPlayer = player.transform.position - transform.position;
        directionToPlayer.y = 0;
        Quaternion lookRotation = Quaternion.LookRotation(-directionToPlayer);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 1.5f);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void AttackPlayer()
    {
        transform.LookAt(player.transform); 
        animationComponent.Play("Attack2");
        playerLifeScript.Die();
    }

    void Die()
    {
        transform.LookAt(player.transform); 
        animationComponent.Play("Death");
        Invoke(nameof(DestroyMonster), 1.5f);
    }

    void DestroyMonster()
    {
        Destroy(gameObject);
    }

}
