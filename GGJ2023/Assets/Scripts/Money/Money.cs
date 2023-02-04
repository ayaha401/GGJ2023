using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    private int money;
    public int moneyProp => money;

    /// <summary>
    /// ������������������
    /// </summary>
    public void Init()
    {
        money = GameParameter.MONEY_INIT;
    }

    /// <summary>
    /// �����������Z
    /// </summary>
    /// <param name="value">���Z��</param>
    public void Plus(int value)
    {
        money += value;
        money = Mathf.Min(money, GameParameter.MONEY_MAX);
    }

    /// <summary>
    /// �����������炷
    /// </summary>
    /// <param name="value">���炷��</param>
    public void Minus(int value)
    {
        money -= value;
        money = Mathf.Max(money, GameParameter.MONEY_MIN);
    }
}
