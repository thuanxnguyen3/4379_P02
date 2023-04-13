using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelSelectState : GameBaseState
{
    public override void EnterState(GameStateManager game, GameController controller)
    {
        controller.showLevelSelect();
        CurrentStateData.currentState = this;
    }

    public override void ExitState(GameStateManager game, GameController controller)
    {
        base.ExitState(game, controller);
        CurrentStateData.toLevelSelectState = false;
    }

    public override void UpdateState(GameStateManager game, GameController controller)
    {
        
    }
}
