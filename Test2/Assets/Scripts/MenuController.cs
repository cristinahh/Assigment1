using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{
    [Header("Levels to Load")]
    public string _newGameLevel; // We are going to run this when we create a new game
    private string levelToLoad; // We load our level when we need it
    [SerializeField] private GameObject noSavedGameDialog = null;

    public void NewGameDialogYes()
    {
        SceneManager.LoadScene(_newGameLevel); // Load the scene when we ask it to
    }

    public void LoadGameDialogYes()
    {
        if(PlayerPrefs.HasKey("SavedLevel")) // Check if we have a file that says "SavedLevel"
        {
            levelToLoad = PlayerPrefs.GetString("SavedLevel");
            SceneManager.LoadScene(levelToLoad);

        }
        else
        {   // if we dont have anything to load, then we want to Pop the NoSaveGame Dialog
            noSavedGameDialog.SetActive(true);
        }
    }

    public void TutorialButton()
    {
        SceneManager.LoadScene(2); // Will open the Tutorial scene 
    }

    public void ExitButton()
    {
        Application.Quit(); // Exit the Game
    }
}
