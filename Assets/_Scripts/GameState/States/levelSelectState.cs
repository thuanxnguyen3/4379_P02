using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelSelectState : GameBaseState
{
    public override void EnterState(GameStateManager game, GameController controller)
    {
        Debug.Log("load the level Select");
        controller.toggleLevelSelect();
        CurrentStateData.currentState = this;
    }

    public override void ExitState(GameStateManager game, GameController controller)
    {
        base.ExitState(game, controller);
        controller.toggleLevelSelect();
        CurrentStateData.toLevelSelectState = false;
    }

    public override void UpdateState(GameStateManager game, GameController controller)
    {
        if(CurrentStateData.toMenuState == true)
        {
            ExitState(game, controller);
            game.SwitchState(game.menuState);
        }
    }
}
