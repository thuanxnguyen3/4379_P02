using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    GameBaseState currentState;

    public mainMenuState menuState = new mainMenuState();
    public levelSelectState selectState = new levelSelectState();
    public playState playState = new playState();
    public pauseState pauseState = new pauseState();
    public winState winState = new winState();

    private GameController gameController;
    void Start()
    {
        gameController = this.GetComponent<GameController>();
        currentState = menuState;
        CurrentStateData.currentState = currentState;
        //Debug.Log("start");

        currentState.EnterState(this, gameController);
    }
    void Update()
    {
        currentState.UpdateState(this, gameController);
        //Debug.Log(currentState.ToString());
    }
    public void SwitchState(GameBaseState state)
    {
        currentState = state;
        CurrentStateData.currentState = state;
        state.EnterState(this, gameController);
    }
    public void LeaveState(GameBaseState state)
    {
        state.ExitState(this, gameController);
    }
    public void stopTheGame()
    {
        Time.timeScale = 0;
    }
    public void unpauseTheGame()
    {
        Time.timeScale = 1.0f;
    }

}
