using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTargetItem : MonoBehaviour
{
    //public TaskController otherClass;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="pickable")
        {
            Destroy(other.gameObject);
            GameObject.Find("Player").GetComponent<TaskController>().TaskCompleted();
            Destroy(gameObject);
        }
    }
}
