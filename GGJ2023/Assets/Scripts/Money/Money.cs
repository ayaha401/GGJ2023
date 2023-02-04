using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    private int money;
    public int moneyProp => money;

    /// <summary>
    /// 所持金を初期化する
    /// </summary>
    public void Init()
    {
        money = GameParameter.MONEY_INIT;
    }

    /// <summary>
    /// 所持金を加算
    /// </summary>
    /// <param name="value">加算量</param>
    public void Plus(int value)
    {
        money += value;
        money = Mathf.Min(money, GameParameter.MONEY_MAX);
    }

    /// <summary>
    /// 所持金を減らす
    /// </summary>
    /// <param name="value">減らす量</param>
    public void Minus(int value)
    {
        money -= value;
        money = Mathf.Max(money, GameParameter.MONEY_MIN);
    }
}
