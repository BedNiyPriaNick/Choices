using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string game, settings;
    [SerializeField] private GameObject click;

    public void StartTheGame()
    {
        SceneManager.LoadScene(game);
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene(settings);
    }

    public void ExitApp()
    {
        Application.Quit();
    }

    public void SoundClick()
    {
        Instantiate(click);
    }
}
