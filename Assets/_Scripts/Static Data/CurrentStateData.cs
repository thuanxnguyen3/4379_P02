using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CurrentStateData
{
    public static GameBaseState currentState { get; set; }

    [Header("StateVariables")]
    public static bool toMenuState = false;
    public static bool toLevelSelectState = false;
    public static bool toPlayState = false;
    public static bool toPauseState = false;
    public static bool toWinState = false;

    public static bool fromPauseState = false;

}
