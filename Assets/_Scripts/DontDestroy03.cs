using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy03 : MonoBehaviour
{
    private static GameObject Instance3 = null;
    private void Awake()
    {
        if (Instance3 == null)
        {
            // doesn't exist yet, this is now our singleton!
            Instance3 = this.gameObject;
            DontDestroyOnLoad(this);
            //fill references
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
