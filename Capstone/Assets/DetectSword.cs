using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectSword : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="pickable")
        {
            GameObject.Find("Player").GetComponent<TaskController>().TaskCompleted();
            Destroy(gameObject);
        }
    }
}
