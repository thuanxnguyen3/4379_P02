using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winState : GameBaseState
{
    public override void EnterState(GameStateManager game, GameController controller)
    {
        Debug.Log("load win state");
        CurrentStateData.currentState = this;

    }

    public override void ExitState(GameStateManager game, GameController controller)
    {
        CurrentStateData.toWinState = false;
    }


    public override void UpdateState(GameStateManager game, GameController controller)
    {
        if (CurrentStateData.toMenuState == true)
        {
            game.LeaveState(game.winState);
            game.SwitchState(game.menuState);
        }
    }
}
