using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private bool invincible = false;
    public float invincibilityTime = 10f;

    public void Die()
    {
        GetComponent<Movement>().enabled = false;
        Invoke(nameof(DisplayMenu), 1.3f);
    }

    private void DisplayMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void BecomeInvincible()
    {
        invincible = true;
        Invoke(nameof(LoseInvincibility), invincibilityTime);
    }

    private void LoseInvincibility()
    {
        invincible = false;
    }

    public bool IsInvincible()
    {
        return invincible;
    }
}
