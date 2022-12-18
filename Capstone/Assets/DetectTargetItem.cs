using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTargetItem : MonoBehaviour
{
    //public TaskController otherClass;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("o");
        if(other.gameObject.tag=="pickable")
        {
            Debug.Log("inside");
            Destroy(other.gameObject);
            GameObject.Find("Player").GetComponent<TaskController>().TaskCompleted();
            Destroy(gameObject);
        }
    }
}
