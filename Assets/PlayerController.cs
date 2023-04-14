using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private InputAction mainMenu;
    private InputAction resume;
    private InputAction pause;
    private InputAction quit;
    private InputAction levelSelect;
    private InputAction startGame;


    private InputAction level01;
    private InputAction level02;
    private InputAction level03;

    private UIButtons buttonControl;

    private void Awake()
    {
        buttonControl = new UIButtons();
    }
    private void OnEnable()
    {
        mainMenu = buttonControl.UI.MainMenu;
        resume = buttonControl.UI.Resume;
        pause = buttonControl.UI.Pause;
        quit= buttonControl.UI.Quit;
        startGame = buttonControl.UI.Start;
        levelSelect = buttonControl.UI.LevelSelect;


        mainMenu.Enable();
        resume.Enable();
        pause.Enable();
        quit.Enable();
        levelSelect.Enable();
        startGame.Enable();


        mainMenu.performed += openMainMenu;
        resume.performed += toPlayState;
        startGame.performed += toPlayState;
        quit.performed += quitGame;
        levelSelect.performed += levelSelectMenu;



        level01 = buttonControl.LevelSelect.Level1;
        level02= buttonControl.LevelSelect.Level2;
        level03= buttonControl.LevelSelect.Level3;

        level01.Enable();
        level02.Enable();
        level03.Enable();

        level01.performed += moveLevel01;
        level02.performed += moveLevel02;
        level03.performed += moveLevel03;
    }
    private void OnDisable()
    {
        mainMenu.Disable();
        resume.Disable();
        pause.Disable();
        quit.Disable();
        levelSelect.Disable();
        startGame.Disable();
    }

    public void toPlayState(InputAction.CallbackContext context)
    {
        CurrentStateData.toPlayState= true;
    }
    public void openMainMenu(InputAction.CallbackContext context)
    {
        CurrentStateData.toMenuState = true;
    }

    public void resumeGame(InputAction.CallbackContext context)
    {
        CurrentStateData.toPlayState = true;
    }

    public void levelSelectMenu(InputAction.CallbackContext context)
    {
        CurrentStateData.toLevelSelectState = true;
    }

    public void quitGame(InputAction.CallbackContext context)
    {
        Application.Quit();
    }
    public void moveLevel01(InputAction.CallbackContext context)
    {
        GameData.selectedLevel = "Level01";
        SceneManager.LoadScene(GameData.selectedLevel);
    }
    public void moveLevel02(InputAction.CallbackContext context)
    {
        GameData.selectedLevel = "Level02";
        SceneManager.LoadScene(GameData.selectedLevel);
    }
    public void moveLevel03(InputAction.CallbackContext context)
    {
        GameData.selectedLevel = "Level03";
        SceneManager.LoadScene(GameData.selectedLevel);
    }

}

