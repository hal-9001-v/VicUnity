using System;
using UnityEngine;

[Serializable]
public class TimeCounter
{
    [SerializeField] float time;
    float elapsedTime;

    public float NormalizedTime
    {
        get
        {
            if (time == 0)
            {
                return 0;
            }

            return Mathf.Clamp01(elapsedTime / time);
        }
    }

    public bool IsFinished => elapsedTime >= time;

    public TimeCounter(float time)
    {
        this.time = time;
    }

    public bool Update()
    {
        return Update(Time.deltaTime);
    }

    public bool Update(float deltaTime)
    {
        elapsedTime += deltaTime;
        if (elapsedTime >= time)
        {
            return true;
        }
        return false;
    }
    public void Reset()
    {
        elapsedTime = 0;
    }

    public void Reset(float time)
    {
        this.time = time;
        elapsedTime = 0;
    }


}
