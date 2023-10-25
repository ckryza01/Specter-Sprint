using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOpen : MonoBehaviour
{

    [SerializeField] MenuManager manager;
    [SerializeField] Menu Screen1, Screen2;

    void Start()
    {

        StartCoroutine(Load());

    }

    IEnumerator Load()
    {

        Debug.Log("Loading");
        yield return new WaitForSeconds(4f);
        manager.Close(Screen1);
        manager.Open(Screen2);

    }

}
