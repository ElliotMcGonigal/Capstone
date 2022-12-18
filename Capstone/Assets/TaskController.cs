using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskController : MonoBehaviour
{
    public int tasksCompleted = 0;
    public string[] taskList= new string[]{"FindAndDeliver", "AvoidEnemy", "DefeatEnemy", "GoToLocation", "JumpFiveTimes"};

    void Update()
    {
        
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
