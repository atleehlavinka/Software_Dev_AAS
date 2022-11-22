using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public AudioSource winTheme;

    public void SetActive()
    {
        gameObject.SetActive(true);
        winTheme.Play();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Restart()
    {
        gameObject.SetActive(false);
        winTheme.Stop();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
