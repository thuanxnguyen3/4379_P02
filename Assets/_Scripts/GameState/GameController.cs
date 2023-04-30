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
    private GameObject winMenuUI;

    private void Awake()
    {
       // Instantiate(pauseMenuUI);
        //Instantiate(levelSelectUI);
    }
    public void Update()
    {
       // Debug.Log(CurrentStateData.toPauseState);
    }
    public void StartGame()
    {
        CurrentStateData.toPlayState = true;
        SceneManager.LoadScene("Level01");
        PlayerPrefs.SetInt("Score", 0);
    }

    //this is a big reset of the game state machine and will bring the player back to the main menu.
    public void toMenuState()
    {
        SceneManager.LoadScene("Main");
        CurrentStateData.toMenuState = false;
        CurrentStateData.toWinState = false;
        CurrentStateData.toLevelSelectState= false;
        CurrentStateData.toPauseState= false;
        CurrentStateData.toPlayState= false;
    }
    public void toggleLevelSelect()
    {
        levelSelectUI.GetComponent<Animator>().SetTrigger("Show Level");
    }
    public void togglePauseMenu()
    {
        pauseMenuUI.GetComponent<Animator>().SetTrigger("Show Pause");
    }
    public void showMainMenu()
    {
        SceneManager.LoadScene("Main");
    }
    public void hideMainMenu()
    {
        MainMenuUI.SetActive(false);
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
