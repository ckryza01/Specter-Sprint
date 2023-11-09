using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{

    [SerializeField] GameObject objectToSpawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Vector3 spawnPosition = transform.position;
            GameObject spawnedMonster = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);

            //change animation to walk
            Animation animationComponent = spawnedMonster.GetComponent<Animation>();
            if (animationComponent != null)
            {
                animationComponent.Play("Walk");
            }
            
            //Chase player
            WaypointFollower waypointFollower = spawnedMonster.AddComponent<WaypointFollower>();
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            waypointFollower.addWaypoint(player);
        }
    }  
            

}
