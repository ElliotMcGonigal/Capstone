using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonCircle : MonoBehaviour
{
    float timeCounter = 0;
    float speed;
    float width;
    void Start()
    {
        speed = .1f;
        width = 18f;
    }

    void Update()
    {
        timeCounter += Time.fixedDeltaTime*speed;

        float x = (Mathf.Cos(timeCounter))*width;
        float y = 5;
        float z = (Mathf.Sin(timeCounter))*width;
        float xx = (Mathf.Cos(timeCounter + speed))*width;
        float zz = (Mathf.Cos(timeCounter + speed))*width;

        transform.position = new Vector3(x, y, z);
        transform.LookAt(new Vector3(xx, y, zz));
    }
}