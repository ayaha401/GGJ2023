using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Money : MonoBehaviour
{
    [HideInInspector] public bool changeable = false;
    private int money;
    public int moneyProp => money;
    public Action moneyUIDraw;

    /// <summary>
    /// ������������������
    /// </summary>
    public void Init()
    {
        if (!changeable) return;
        money = GameParameter.MONEY_INIT;
        money = Mathf.Clamp(money, GameParameter.MONEY_MIN, GameParameter.MONEY_MAX);
        moneyUIDraw();
    }

    /// <summary>
    /// �����������Z
    /// </summary>
    /// <param name="value">���Z��</param>
    public void Plus(int value)
    {
        if (!changeable) return;
        money += value;
        money = Mathf.Min(money, GameParameter.MONEY_MAX);
        moneyUIDraw();
    }

    /// <summary>
    /// �����������炷
    /// </summary>
    /// <param name="value">���炷��</param>
    public void Minus(int value)
    {
        if (!changeable) return;
        money -= value;
        money = Mathf.Max(money, GameParameter.MONEY_MIN);
        moneyUIDraw();
    }
}
