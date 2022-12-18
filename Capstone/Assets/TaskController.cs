using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskController : MonoBehaviour
{
    public int tasksCompleted = 0;
    public GameObject TargetItem;
    public GameObject TargetLocation;
    public GameObject PlayerLocation;
    public GameObject EnemyDefeat;
    public int Jumps = 0;
    public string currentTask;
    public string[] taskList= new string[]{"FindAndDeliver", "DefeatEnemy", "GoToLocation", "JumpFiveTimes"};

    void Start()
    {
        currentTask = "JumpFiveTimes";
        JumpFiveTimes();
    }

    public void TaskCompleted()
    {
        Jumps = 0;
        tasksCompleted++;
        int rand = Random.Range(0, 4);
        Debug.Log(taskList[rand]);
        string tempTask = taskList[rand];
        currentTask = tempTask;
        Invoke(tempTask, 1f);
    }

    void FindAndDeliver()
    {
        Instantiate(TargetItem, new Vector3(0, 1, 0), Quaternion.identity);
        Instantiate(TargetLocation, new Vector3(5, -5, 6), Quaternion.identity);
    }
    void DefeatEnemy()
    {
        Instantiate(EnemyDefeat, new Vector3(9, 0, 9), Quaternion.identity);
    }
    void GoToLocation()
    {
        Instantiate(PlayerLocation, new Vector3(-3, 0, -7), Quaternion.identity);
    }
    void JumpFiveTimes()
    {

    }
    public void Jumped()
    {
        Debug.Log("got here");
        if (currentTask == "JumpFiveTimes")
        {
            Jumps++;
        }
        if (Jumps >= 5)
        {
            TaskCompleted();
        }
    }
}
