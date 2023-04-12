using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerMove : MonoBehaviour
{

    //public bool isFlat = true;
    //private Rigidbody rigidBody;

    private void Start()
    {
        //rigidBody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        /* Vector3 tilt = Input.acceleration;

        if (isFlat)
            tilt = Quaternion.Euler(90, 0, 0) * tilt; // rotate a vector super quick

        rigidBody.AddForce(tilt);

        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.cyan); */





    }
    private void FixedUpdate()
    {

    }

}
