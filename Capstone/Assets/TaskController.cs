using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskController : MonoBehaviour
{
    public int tasksCompleted = 0;
    public GameObject TargetItem;
    public GameObject TargetLocation;
    public string[] taskList= new string[]{"FindAndDeliver", "AvoidEnemy", "DefeatEnemy", "GoToLocation", "JumpFiveTimes"};

    void Start()
    {
        FindAndDeliver();
    }

    public void TaskCompleted()
    {
        tasksCompleted++;
        int rand = Random.Range(0, 5);
        string tempTask = taskList[rand];
        Invoke(tempTask, 0);
    }

    void FindAndDeliver()
    {
        Instantiate(TargetItem, new Vector3(0, 1, 0), Quaternion.identity);
        Instantiate(TargetLocation, new Vector3(5, -5, 6), Quaternion.identity);
    }
    void AvoidEnemy()
    {

    }
    void DefeatEnemy()
    {

    }
    void GoToLocation()
    {

    }
    void JumpFiveTimes()
    {

    }
}
