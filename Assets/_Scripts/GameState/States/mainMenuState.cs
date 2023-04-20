using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuState : GameBaseState
{
    public override void EnterState(GameStateManager game, GameController controller)
    {
        Debug.Log("MainMenuLoad");
        CurrentStateData.currentState = this;
        controller.MainMenuUI.SetActive(true);
    }
    public override void ExitState(GameStateManager game, GameController controller)
    {
        CurrentStateData.toMenuState = false;
    }
    public override void UpdateState(GameStateManager game, GameController controller)
    {
        if (CurrentStateData.toLevelSelectState == true)
        {
            ExitState(game, controller);
            game.SwitchState(game.selectState);
        }
        if(CurrentStateData.toPlayState== true)
        {
            ExitState(game, controller);
            game.SwitchState(game.playState);
            controller.MainMenuUI.SetActive(false);
        }
    }
}
