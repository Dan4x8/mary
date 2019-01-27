using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class DNCamScript : MonoBehaviour
{
    [SerializeField]
    private TimeManager _timeManager;

    private Camera _windowCamera;

    private void Start()
    {
        _windowCamera = GetComponent<Camera>();
    }

    private void Update()
    {
        float dayPercent = _timeManager.GetDayTime() / _timeManager.DayLength;
        // Sinus shifting magic vor v (hsv) value
        var v = (Mathf.Sin(dayPercent * Mathf.PI * 2f - Mathf.PI * .5f) * .5f + .5f);
        _windowCamera.backgroundColor = Color.HSVToRGB(0f, 0f, v);
    }
}
