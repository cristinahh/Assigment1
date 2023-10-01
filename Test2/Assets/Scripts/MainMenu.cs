using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1); // Will open the play game scene 
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(2); // Will open the Tutorial scene 
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }
}