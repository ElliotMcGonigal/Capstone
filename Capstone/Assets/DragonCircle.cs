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
        transform.rotation = Quaternion.Euler(0, 90, 0);
        speed = .1f;
        width = 18f;
    }

    void Update()
    {
        timeCounter += Time.fixedDeltaTime*speed;

        float x = (Mathf.Cos(timeCounter))*width;
        float y = 5;
        float z = (Mathf.Sin(timeCounter))*width;

        transform.position = new Vector3(x, y, z);
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(x, y, z));
        transform.rotation = Quaternion.Euler(lookRotation.eulerAngles.x, lookRotation.eulerAngles.y - 90, lookRotation.eulerAngles.z);
    }
}