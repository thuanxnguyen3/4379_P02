using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseState : GameBaseState
{
    public override void EnterState(GameStateManager game, GameController controller)
    {
        Debug.Log("load pause state");
        CurrentStateData.currentState = this;
        game.stopTheGame();
        controller.showPauseMenu();
    }

    public override void ExitState(GameStateManager game, GameController controller)
    {
        base.ExitState(game, controller);
        game.unpauseTheGame();
        controller.hidePauseMenu();
        CurrentStateData.toPauseState= false;
    }

    public override void UpdateState(GameStateManager game, GameController controller)
    {
        if (CurrentStateData.toPlayState == true)
        {
            ExitState(game, controller);
            game.SwitchState(game.playState);
        }
    }
}
