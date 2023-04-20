using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseState : GameBaseState
{
    public override void EnterState(GameStateManager game, GameController controller)
    {
        Debug.Log("load pause state");
        CurrentStateData.currentState = this;
        controller.togglePauseMenu();
        Time.timeScale= 0;
        CurrentStateData.fromPauseState= true;
    }

    public override void ExitState(GameStateManager game, GameController controller)
    {
        base.ExitState(game, controller);
        controller.togglePauseMenu();
        Time.timeScale = 1f;
        CurrentStateData.toPauseState= false;
    }
    public override void UpdateState(GameStateManager game, GameController controller)
    {
        if (CurrentStateData.toPlayState == true)
        {
            ExitState(game, controller);
            game.SwitchState(game.playState);
        }
        if(CurrentStateData.toMenuState== true)
        {
            ExitState(game, controller);
            game.SwitchState(game.menuState);
            CurrentStateData.fromPauseState = false;
        }
    }
}
