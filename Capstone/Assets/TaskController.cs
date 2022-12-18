using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
        currentTask = "GoToLocation";
        GoToLocation();
    }

    public void TaskCompleted()
    {
        Jumps = 0;
        tasksCompleted++;
        GameObject.Find("Score").GetComponent<TextMeshProUGUI>().text = "Score: " + tasksCompleted.ToString();
        int rand = Random.Range(0, 4);
        Debug.Log(taskList[rand]);
        string tempTask = taskList[rand];
        currentTask = tempTask;
        Invoke(tempTask, 1f);
    }

    void FindAndDeliver()
    {
        GameObject.Find("Task").GetComponent<TextMeshProUGUI>().text = "Current Objective: Find the orb and place it in the pillar.";
        Instantiate(TargetItem, new Vector3(0, 1, 0), Quaternion.identity);
        Instantiate(TargetLocation, new Vector3(5, -5, 6), Quaternion.identity);
    }
    void DefeatEnemy()
    {
        GameObject.Find("Task").GetComponent<TextMeshProUGUI>().text = "Current Objective: Defeat the Goblin";
        Instantiate(EnemyDefeat, new Vector3(9, 0, 9), Quaternion.identity);
    }
    void GoToLocation()
    {
        GameObject.Find("Task").GetComponent<TextMeshProUGUI>().text = "Current Objective: Go to the Circle";
        Instantiate(PlayerLocation, new Vector3(-3, 0, -7), Quaternion.identity);
    }
    void JumpFiveTimes()
    {
        GameObject.Find("Task").GetComponent<TextMeshProUGUI>().text = "Current Objective: Jump five times";
    }
    public void Jumped()
    {
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
