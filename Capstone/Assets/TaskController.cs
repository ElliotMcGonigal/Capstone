using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskController : MonoBehaviour
{
    public int tasksCompleted = 0;
    public GameObject TargetItem;
    public GameObject TargetLocation;
    public GameObject PlayerLocation;
    public string[] taskList= new string[]{"FindAndDeliver", "AvoidEnemy", "DefeatEnemy", "GoToLocation", "JumpFiveTimes"};

    void Start()
    {
        GoToLocation();
    }

    public void TaskCompleted()
    {
        tasksCompleted++;
        int rand = Random.Range(0, 5);
        Debug.Log(taskList[rand]);
        string tempTask = taskList[rand];
        Invoke(tempTask, 1f);
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
        Instantiate(PlayerLocation, new Vector3(-3, 0, -7), Quaternion.identity);
    }
    void JumpFiveTimes()
    {

    }
}
