using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuState : GameBaseState
{
    public override void EnterState(GameStateManager game, GameController controller)
    {
        Debug.Log("MainMenuLoad");
    }

    public override void ExitState(GameStateManager game, GameController controller)
    {
        controller.toMenuState = false;
    }

    public override void UpdateState(GameStateManager game, GameController controller)
    {
        if (controller.toLevelSelectState == true)
        {
            game.LeaveState(game.menuState);
            game.SwitchState(game.selectState);
        }
        if(controller.toPlayState== true)
        {
            game.LeaveState(game.menuState);
            game.SwitchState(game.playState);
        }
    }
}
