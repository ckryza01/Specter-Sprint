using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OrbCounter : MonoBehaviour
{
    public TextMeshProUGUI orbCountText;
    public GameObject finish;
    public int collectedOrbs = 0;
    public int totalOrbs = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateOrbCountText();
    }

    void UpdateOrbCountText()
    {
        orbCountText.text = "Orbs Collected: " + collectedOrbs + " / " + totalOrbs;
    }


    public void IncrementOrbCount()
    {
        collectedOrbs++;
        UpdateOrbCountText();

        if(collectedOrbs >= totalOrbs){
            orbCountText.text = "All Orbs Collected, ESCAPE!";
            finish.SetActive(true);
        }
    }
    
    public void SetTotalOrbs(int total)
    {
        totalOrbs = total;
        UpdateOrbCountText();
    }

}
