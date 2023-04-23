using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class GameTask : MonoBehaviour
{
    public string description;

    [SerializeField]
    public float time;

    public string priority;

    private Button button;

    void Start(){
        button = GetComponent<Button>();
        if (button != null)
        {
            button.GetComponentInChildren<TextMeshProUGUI>().text = description;
        }
    }

    public GameTask(){}

    public GameTask(string description, float time, string priority)
    {
        this.description = description;
        this.time = time;
        this.priority = priority;
    }

    // Use integer index to access Priority enum
    public void SetPriority(string priority)
    {
        this.priority = priority;
    }

    public void DoTask()
    {

    }

    public void TaskTransition()
    {

    }
}
