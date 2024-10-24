using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void PlayLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Play2Players()
    {
        SceneManager.LoadScene("2 Players");
    }
    public void BackMainMenu()
    {
        SceneManager.LoadScene("Main menu");
    }
    public void QuitGame()
    {
        Debug.Log("Quit Game!");
        Application.Quit();
    }
    void Update()
    {
        
    }
}
