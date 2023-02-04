using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    [HideInInspector] public bool changeable = false;
    private float limit;
    public float limitProp => limit;
    public Action<float> timerUIDraw;

    /// <summary>
    /// ����������
    /// </summary>
    public void Init()
    {
        if (!changeable) return;
        limit = GameParameter.TIME_LIMIT;
        timerUIDraw(limit);
    }

    /// <summary>
    /// ���Ԃ��i��
    /// </summary>
    public bool CheckTimeUp()
    {
        if (limit < 0f)
        {
            return true;
        }
        else
        {
            limit -= Time.deltaTime;
            timerUIDraw(limit);
            return false;
        }
    }
}
