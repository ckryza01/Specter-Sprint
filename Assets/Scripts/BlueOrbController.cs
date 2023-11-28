using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueOrbController : OrbController
{
    protected override void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            PlayerLife playerLifeScript = player.GetComponent<PlayerLife>();
            playerLifeScript.BecomeInvincible();
            base.OnTriggerEnter(other);
        }
    }
}
