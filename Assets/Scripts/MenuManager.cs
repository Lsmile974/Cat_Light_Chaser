using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void GoMainMenu()
    {
        // Load the Level map scene
        SceneManager.LoadScene("Main_menu");
    }
    public void GoLevelMap()
    {
        // Load the Level map scene
        SceneManager.LoadScene("Levels_map");
    }

    public void GoLevel1()
    {
        // Load the Level map scene
        SceneManager.LoadScene("Level 1");
    }

    public void GoOptions()
    {
        // Load the Level map scene
        SceneManager.LoadScene("Options");
    }

    public void CloseGame()
    {
        // Quit the game
        Application.Quit();
    }
}
