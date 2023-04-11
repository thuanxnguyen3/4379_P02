using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winState : GameBaseState
{
    public override void EnterState(GameStateManager game, GameController controller)
    {
        throw new System.NotImplementedException();
    }

    public override void ExitState(GameStateManager game, GameController controller)
    {
        base.ExitState(game, controller);
    }

    public override void OnCollisionEnter(GameStateManager game, GameController controller)
    {
        base.OnCollisionEnter(game, controller);
    }

    public override void UpdateState(GameStateManager game, GameController controller)
    {
        throw new System.NotImplementedException();
    }
}
