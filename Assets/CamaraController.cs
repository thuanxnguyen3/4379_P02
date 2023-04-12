using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{

    //public GameObject player;

    public Transform player;

    public Vector3 playerOffset;

    public float cameraSmooth = 0.3f;

    // Use this for initialization
    private Vector3 velocity = Vector3.zero;

    void Start()
    {


    }
    // Update is called once per frame

    void FixedUpdate() // FIXEDupdate will run after update will reduce camera jitter. 
    {

        Vector3 wantedPosition = player.position + playerOffset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, wantedPosition, ref velocity, cameraSmooth);
        transform.position = smoothedPosition;

        transform.LookAt(player);

    }


}
