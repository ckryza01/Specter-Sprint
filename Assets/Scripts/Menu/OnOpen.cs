using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOpen : MonoBehaviour
{

    [SerializeField] MenuManager manager;
    [SerializeField] Menu Screen1;

    void Start()
    {

        StartCoroutine(Load());

    }

    IEnumerator Load()
    {

        Debug.Log("Loading");
        yield return new WaitForSeconds(4f);
        manager.Open(Screen1);

    }

}
