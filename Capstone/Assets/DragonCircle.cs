using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonCircle : MonoBehaviour
{
    float timeCounter = 0;
    void Start()
    {
        
    }

    void Update()
    {
        timeCounter += Time.fixedDeltaTime;

        float x = Mathf.Cos(timeCounter);
        float y = 5;
        float z = Mathf.Sin(timeCounter);

        transform.position = new Vector3(x, y, z);
    }
}
