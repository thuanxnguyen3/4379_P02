using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    private static GameObject Instance1 = null;
    private void Awake()
    {
        if (Instance1 == null)
        {
            // doesn't exist yet, this is now our singleton!
            Instance1 = this.gameObject;
            DontDestroyOnLoad(this);
            //fill references
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
