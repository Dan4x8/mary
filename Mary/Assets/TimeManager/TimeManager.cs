using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public const int DAY_LENGTH = 86400;

    [SerializeField]
    private float _dayTime = 0f;

    [SerializeField]
    private float _dayLength = 1440f;

    public static TimeManager Instance = null;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }

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

    public int GetDaySeconds()
    {
        return (int)_seconds;
    }

    public float GetDayTime()
    {
        return _dayTime;
    }
    
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

    public void ChangeGameSpeed(float value)
    {
        Time.timeScale = value;
    }
}
