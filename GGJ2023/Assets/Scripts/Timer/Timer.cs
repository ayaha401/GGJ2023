using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    [HideInInspector] public bool changeable = false;
    private float limit;
    public float limitProp => limit;

    private bool timeUp = false;
    public bool onTimeUp => timeUp;

    public Action<float> timerUIDraw;

    /// <summary>
    /// 初期化する
    /// </summary>
    public void Init()
    {
        if (!changeable) return;
        limit = GameParameter.TIME_LIMIT;
        timerUIDraw(limit);
    }

    /// <summary>
    /// 時間が進む
    /// </summary>
    public bool CheckTimeUp()
    {
        if (limit < 0f)
        {
            timeUp = true;
            return true;
        }
        else
        {
            limit -= Time.deltaTime;
            timerUIDraw(limit);
            timeUp = false;
            return false;
        }
    }
}
