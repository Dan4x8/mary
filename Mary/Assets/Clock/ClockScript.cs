using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockScript : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshPro _text;

    [SerializeField]
    private TimeManager _timeManager;

    private void Awake()
    {
        _text = GetComponent<TMPro.TextMeshPro>();
    }

    private void Update()
    {
        UpdateClock();
    }
    public void UpdateClock()
    {
        _text.text = string.Format("{0:00}:{1:00}", _timeManager.GetClockHours(),_timeManager.GetClockMinutes());
    }
}
