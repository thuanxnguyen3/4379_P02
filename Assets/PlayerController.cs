using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private InputAction mainMenu;
    private InputAction resume;
    private InputAction pause;
    private InputAction quit;
    private InputAction levelSelect;
    private InputAction startGame;

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

}

