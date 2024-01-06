using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    public GameObject[] waypoints;
    int currentWayPointIndex = 0;
    public float speed = 1f;
    void Update()
    {
        if(Vector3.Distance(transform.position, waypoints[currentWayPointIndex].transform.position) < .1f)
        {
            currentWayPointIndex++;
            if (currentWayPointIndex >= waypoints.Length) 
            { 
                currentWayPointIndex = 0; 
            }

        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWayPointIndex].transform.position, speed * Time.deltaTime);
    }
}
