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
    public Action scoreUIDraw;

    [SerializeField] private MoneySound sound;

    /// <summary>
    /// 所持金を初期化する
    /// </summary>
    public void Init()
    {
        if (!changeable) return;
        money = GameParameter.MONEY_INIT;
        money = Mathf.Clamp(money, GameParameter.MONEY_MIN, GameParameter.MONEY_MAX);
        moneyUIDraw();
    }

    /// <summary>
    /// 所持金を加算
    /// </summary>
    /// <param name="value">加算量</param>
    public void Plus(int value)
    {
        if (!changeable) return;
        money += value;
        money = Mathf.Min(money, GameParameter.MONEY_MAX);
        sound.PlayMoneySound();
        moneyUIDraw();
    }

    /// <summary>
    /// 所持金を減らす
    /// </summary>
    /// <param name="value">減らす量</param>
    public void Minus(int value)
    {
        if (!changeable) return;
        money -= value;
        money = Mathf.Max(money, GameParameter.MONEY_MIN);
        moneyUIDraw();
    }
}
