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
    }

    public override void ExitState(GameStateManager game, GameController controller)
    {
        base.ExitState(game, controller);
        game.unpauseTheGame();
    }

    public override void UpdateState(GameStateManager game, GameController controller)
    {
        throw new System.NotImplementedException();
    }
}
