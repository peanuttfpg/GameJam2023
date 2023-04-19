using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public static TaskManager instance;

    [SerializeField]
    private List<GameTask> tasks;

    private int _taskIndex;
    public int taskIndex
    {
        get { return _taskIndex; }
        set { _taskIndex = value; }
    }

    private void Awake()
    {
        if(instance== null) 
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void AddTask(GameTask task)
    {
        instance.tasks.Add(task);
    }

    public static void RemoveTask(GameTask task)
    {
        instance.tasks.Remove(task);
    }
}
