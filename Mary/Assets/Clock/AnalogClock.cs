using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalogClock : MonoBehaviour
{
    [SerializeField]
    private TimeManager _timeManager;

    [SerializeField]
    [Range(-1,1)]
    private int _direction = 1;

    [SerializeField]
    private float _hoursOnClock = 12;

    [SerializeField]
    private float rotationOffset;

    private void Update()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, (_timeManager.GetDaySeconds()/_timeManager.DayLength/_hoursOnClock)*-_direction + rotationOffset);
    }
}
