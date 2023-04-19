using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Priority
    {
        Low,
        Medium,
        High
    }

public class GameTask : MonoBehaviour
{
    private string description { get; set; }

    private float time { get; set; }

    private string priority { get; set; }

    public GameTask(){}

    public GameTask(string description, float time, string priority)
    {
        this.description = description;
        this.time = time;
        this.priority = priority;
    }

    // Use integer index to access Priority enum
    public void SetPriority(int index)
    {
        this.priority = ((Priority)index).ToString();
    }
}
