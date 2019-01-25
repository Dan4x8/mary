using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public const int DAY_LENGTH = 86400;

    [SerializeField]
    private float _dayTime = 0f;

    [SerializeField]
    private float _dayLength = 1440f;

    private void Update()
    {
        _dayTime += Time.deltaTime;

        if(_dayTime >_dayLength)
        {
            _dayTime = 0f;
        }

        _seconds = (_dayTime / _dayLength) * (DAY_LENGTH);
    }

    public float DayLength { get { return _dayLength; } set { _dayLength = value; } }


    [SerializeField]
    private float _seconds;
    
    public int GetClockSeconds()
    {
        return (int)_seconds % 60;
    }
    
    public int GetClockMinutes()
    {
        return ((int)_seconds / 60) % 60;
    }
    
    public int GetClockHours()
    {
        return (int)_seconds / 3600;
    }
}
