using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{
    public AudioSource loseTheme;
    
    public void SetActive()
    {
        gameObject.SetActive(true);
        loseTheme.Play();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Restart()
    {
        gameObject.SetActive(false);
        loseTheme.Stop();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
