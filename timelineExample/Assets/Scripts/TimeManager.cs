using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class TimeManager
{
    private float time;

    public TimeManager()
    {
        TimeDependants = new List<ITimeChanging>();
    }
    
    public float Time
    {
        get
        {
            return time;
        }
        set
        {
            if (value != time)
            {
                var delta = value - time;
                foreach (var timeDep in TimeDependants)
                {
                    timeDep.AddTime(delta);
                }
            }
            time = value;
        }
    }

    public void SetTimeBruteForce(float time)
    {
        this.time = time;
    }
    
    public IEnumerable<ITimeChanging> TimeDependants { get; set; }
}

