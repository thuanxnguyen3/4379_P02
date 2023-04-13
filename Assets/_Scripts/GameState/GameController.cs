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
    public GameObject winMenuUI;

    public void ExitGame()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        CurrentStateData.toPlayState = true;
        SceneManager.LoadScene("Level01");
    }

    //this is a big reset of the game state machine and will bring the player back to the main menu.
    public void toMenuState()
    {
        SceneManager.LoadScene("Main");
        CurrentStateData.toMenuState = true;
        CurrentStateData.toWinState = false;
        CurrentStateData.toLevelSelectState= false;
        CurrentStateData.toPauseState= false;
        CurrentStateData.toPlayState= false;
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
        CurrentStateData.toWinState = true;
    }
    public void showWinMenu()
    {
        winMenuUI.SetActive(true);
    }
    public void hideWinMenu()
    {
        winMenuUI.SetActive(false);
    }

}
