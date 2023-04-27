using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCollider : MonoBehaviour
{
    public string moveToLevel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameData.currentLevel = moveToLevel;
            if(moveToLevel == "Level04")
            {
                CurrentStateData.toMenuState = true;
            }
            else
            {
                SceneManager.LoadScene(moveToLevel);
            }
            
        }
    }
}
