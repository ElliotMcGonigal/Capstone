using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTargetItem : MonoBehaviour
{
    public TaskController otherClass;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="TargetItem")
        {
            Destroy(other.gameObject);
            otherClass.TaskCompleted();
            Destroy(gameObject);
        }
    }
}
