using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 playerOffset;

    // Use this for initialization

    void Start()

    {

        playerOffset = transform.position - player.transform.position; // distance from camera

    }



    // Update is called once per frame

    void Update()

    {

        transform.LookAt(player.transform);

        transform.position = player.transform.position + playerOffset;

    }


}
