using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speedX, speedY, speedZ;
    void Update()
    {
        transform.Rotate(360 * Time.deltaTime * speedX, 360 * Time.deltaTime * speedY, 360 * Time.deltaTime * speedZ);
    }
}
