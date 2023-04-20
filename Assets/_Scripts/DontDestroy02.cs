using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy02 : MonoBehaviour
{
    private static GameObject Instance2 = null;
    private void Awake()
    {
        if (Instance2 == null)
        {
            // doesn't exist yet, this is now our singleton!
            Instance2 = this.gameObject;
            DontDestroyOnLoad(this);
            //fill references
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
