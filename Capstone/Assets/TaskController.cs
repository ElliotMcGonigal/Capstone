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
        GameObject.Find("Task").GetComponent<TextMeshProUGUI>().text = "Current Objective: Find the orb and drop it in the pillar.";
        Instantiate(TargetItem, new Vector3(Random.Range(-29f, 29f), 1, Random.Range(-29f, 29f)), Quaternion.identity);
        Instantiate(TargetLocation, new Vector3(Random.Range(-29f, 29f), -5, Random.Range(-29f, 29f)), Quaternion.identity);
    }
    void DefeatEnemy()
    {
        GameObject.Find("Task").GetComponent<TextMeshProUGUI>().text = "Current Objective: Defeat the Goblin";
        Instantiate(EnemyDefeat, new Vector3(Random.Range(-29f, 29f), 0, Random.Range(-29f, 29f)), Quaternion.identity);
        GameObject.Find("Sword Long").transform.position = new Vector3(0f, 1, 0f);
    }
    void GoToLocation()
    {
        GameObject.Find("Task").GetComponent<TextMeshProUGUI>().text = "Current Objective: Go to the Circle";
        Instantiate(PlayerLocation, new Vector3(Random.Range(-29f, 29f), 0, Random.Range(-29f, 29f)), Quaternion.identity);
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
