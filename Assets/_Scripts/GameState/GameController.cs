using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    [Header("UI")]
    public GameObject MainMenuUI;
    public GameObject levelSelectUI;
    public GameObject pauseMenuUI;

    [Header("StateVariables")]
    public bool toMenuState = false;
    public bool toLevelSelectState = false;
    public bool toPlayState = false;
    public bool toPauseState = false;
    public bool toWinState = false;

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        toPlayState = true;
        SceneManager.LoadScene("Level01");
    }
    public void showLevelSelect()
    {
        levelSelectUI.SetActive(true);
    }
    public void hideLevelSelect()
    {
        levelSelectUI.SetActive(false);
    }
    public void showMainMenu()
    {
        SceneManager.LoadScene("Main");
    }
    public void hideMainMenu()
    {
        MainMenuUI.SetActive(false);
    }
    public void showPauseMenu()
    {
        pauseMenuUI.SetActive(true);
    }
    public void hidePauseMenu()
    {
        pauseMenuUI.SetActive(false);
    }
    public void winState()
    {
        toWinState = true;
    }
}
