using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] Transform startPoint, endPoint;

    [SerializeField] float speed = 3f;

    [SerializeField] float changeDirectionDelay;

    private Transform destinationTarget, departTarget;

    private float startTime;
    private float journeyLength;

    bool isWaiting;

    private void Start()
    {
        departTarget = startPoint;
        destinationTarget = endPoint;

        startTime = Time.time;

        journeyLength = Vector3.Distance(departTarget.position, destinationTarget.position);
    }
    private void FixedUpdate()
    {
        /*
        if(Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < .1f)
        {
            currentWaypointIndex++;
            if(currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position,
            speed * Time.deltaTime);
        */
        Move();
    }

    private void Move()
    {
        if(!isWaiting)
        {
            if(Vector3.Distance(transform.position,destinationTarget.position) > 0.01f)
            {
                float distCovered = (Time.time - startTime) * speed;

                float fractionOfJouney = distCovered / journeyLength;

                transform.position = Vector3.Lerp(departTarget.position, destinationTarget.position, fractionOfJouney);

            }
            else
            {
                isWaiting = true;
                StartCoroutine(ChangeDelay());
            }

        } 
        
    }

    void ChangeDestination()
    {
        if(departTarget == endPoint && destinationTarget == startPoint)
        {
            departTarget = startPoint;
            destinationTarget = endPoint;
        }
        else
        {
            departTarget = endPoint;
            destinationTarget = startPoint;
        }
    }

    IEnumerator ChangeDelay()
    {
        yield return new WaitForSeconds(changeDirectionDelay);
        ChangeDestination();
        startTime = Time.time;
        journeyLength = Vector3.Distance(departTarget.position, destinationTarget.position);
        isWaiting = false;
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.transform.parent = null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.parent = transform;
        }
    }
}
