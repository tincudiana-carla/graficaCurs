using System.Collections;
using UnityEngine;

public class RotatingAndZoomingCamera : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 100f;
    public float zoomSpeed = 5f;
    private bool rotateOnce = false;
    private bool zoomInOnce = false;
    private bool zoomOutOnce = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && !rotateOnce)
        {
            StartCoroutine(RotateAroundOnce());
        }

        if (Input.GetKeyDown(KeyCode.Z) && !zoomInOnce)
        {
            StartCoroutine(ZoomIn());
        }

        if (Input.GetKeyDown(KeyCode.C) && !zoomOutOnce)
        {
            StartCoroutine(ZoomOut());
        }
    }

    IEnumerator RotateAroundOnce()
    {
        rotateOnce = true;

        float angle = 0f;
        float targetAngle = 360f;
        float elapsedTime = 0f;

        while (angle < targetAngle)
        {
            float step = rotationSpeed * Time.deltaTime;
            transform.RotateAround(target.position, Vector3.up, step);
            angle += step;
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        rotateOnce = false;
    }

    IEnumerator ZoomIn()
    {
        zoomInOnce = true;

        Vector3 targetPosition = target.position - transform.forward * 2f;  

        while (Vector3.Distance(transform.position, targetPosition) > 0.1f)
        {
            float step = zoomSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
            yield return null;
        }

        zoomInOnce = false;
    }

    IEnumerator ZoomOut()
    {
        zoomOutOnce = true;

        Vector3 targetPosition = target.position - transform.forward * 6f;  

        while (Vector3.Distance(transform.position, targetPosition) > 0.1f)
        {
            float step = zoomSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
            yield return null;
        }

        zoomOutOnce = false;
    }
}
