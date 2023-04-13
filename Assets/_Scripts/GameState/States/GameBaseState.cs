using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameBaseState
{
    public abstract void EnterState(GameStateManager game, GameController controller);

    public virtual void UpdateState(GameStateManager game, GameController controller)
    {

    }

    public virtual void ExitState(GameStateManager game, GameController controller)
    {

    }

}