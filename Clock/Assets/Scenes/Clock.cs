using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    void Update()        // from Awake to Update
    {
        TimeSpan dateTime = DateTime.Now.TimeOfDay;

        //Debug.Log(DateTime.Now);
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)dateTime.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)dateTime.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)dateTime.TotalSeconds);
    }
}