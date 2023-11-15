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
            Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);

        }
    }  
            

}
