using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="player")
        {
            GameObject.Find("Player").GetComponent<TaskController>().TaskCompleted();
            Destroy(gameObject);
        }
    }
}
