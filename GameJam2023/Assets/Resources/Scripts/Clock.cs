using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    // 1 day = 1440 minutes
    private const float REAL_SECONDS_PER_INGAME_DAY = 720f;

    private Transform clockhandMinuteTransform;
    private Transform clockhandHourTransform;
    private float day;
    private void Awake()
    {
        clockhandMinuteTransform = transform.Find("Clock Minute Hand");
        clockhandHourTransform = transform.Find("Clock Hour Hand");
    }

    // Update is called once per frame
    void Update()
    {
        day += Time.deltaTime / REAL_SECONDS_PER_INGAME_DAY;

        float normalizedDay = day % 1f;
        float rotationDegrees = 360f;
        float hourPerDay = 24f;

        clockhandHourTransform.eulerAngles = new Vector3(0, 0, -normalizedDay * rotationDegrees);
        clockhandMinuteTransform.eulerAngles = new Vector3(0, 0, -normalizedDay * rotationDegrees * hourPerDay);

    }
}
