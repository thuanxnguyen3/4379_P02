using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    [Header("UI")]
    public GameObject MainMenuUI;
    public GameObject levelSelectUI;

    [Header("StateVariables")]
    public bool toMenuState = false;
    public bool toLevelSelectState = false;
    public bool toPlayState = false;

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        
    }
    public void showLevelSelect()
    {
        levelSelectUI.SetActive(true);
    }



}
