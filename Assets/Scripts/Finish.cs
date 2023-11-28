using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Finish : MonoBehaviour
{
    public TextMeshProUGUI gameWonMsg;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            gameWonMsg.text = "You won!";
            Invoke(nameof(DisplayMenu), 1f);
        }
    }

    private void DisplayMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
