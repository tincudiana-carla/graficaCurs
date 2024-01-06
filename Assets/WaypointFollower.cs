using System.Collections;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    public GameObject[] waypoints;
    int currentWayPointIndex = 0;
    public float speed = 1f;
    public float minScale = 0.5f;
    public float maxScale = 1.5f;

    void Start()
    {
        StartCoroutine(RandomScale());
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWayPointIndex].transform.position) < 0.1f)
        {
            currentWayPointIndex++;
            if (currentWayPointIndex >= waypoints.Length)
            {
                currentWayPointIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWayPointIndex].transform.position, speed * Time.deltaTime);
    }

    IEnumerator RandomScale()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            if (gameObject.CompareTag("Enemy"))
            {
                float randomScale = Random.Range(minScale, maxScale);
                transform.localScale = new Vector3(randomScale, randomScale, randomScale);
            }
        }
    }

}
