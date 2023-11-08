using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbManager : MonoBehaviour
{
    public int totalOrbs = 0;

    void Start()
    {
        
        totalOrbs = FindObjectsOfType<OrbController>().Length;

        
        OrbCounter orbCounter = FindObjectOfType<OrbCounter>();
        if (orbCounter != null)
        {
            orbCounter.SetTotalOrbs(totalOrbs);
        }
    }
}
