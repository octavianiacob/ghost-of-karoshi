using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void Start()
    {
        GameObject gameObject = GameObject.Find("HowToPlayMenu");
        if (gameObject)
        gameObject.SetActive(false);
        /*gameObject.SetActive(false);*/
    }
    public void StartFirstLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
       
    }
    public void GoToHowToPlay()
    {
        SceneManager.LoadScene("HowToPlayMenu");
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
