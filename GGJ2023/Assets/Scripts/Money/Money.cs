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
    /// Š‹à‚ğ‰Šú‰»‚·‚é
    /// </summary>
    public void Init()
    {
        if (!changeable) return;
        money = GameParameter.MONEY_INIT;
        money = Mathf.Clamp(money, GameParameter.MONEY_MIN, GameParameter.MONEY_MAX);
        moneyUIDraw();
    }

    /// <summary>
    /// Š‹à‚ğ‰ÁZ
    /// </summary>
    /// <param name="value">‰ÁZ—Ê</param>
    public void Plus(int value)
    {
        if (!changeable) return;
        money += value;
        money = Mathf.Min(money, GameParameter.MONEY_MAX);
        sound.PlayMoneySound();
        moneyUIDraw();
    }

    /// <summary>
    /// Š‹à‚ğŒ¸‚ç‚·
    /// </summary>
    /// <param name="value">Œ¸‚ç‚·—Ê</param>
    public void Minus(int value)
    {
        if (!changeable) return;
        money -= value;
        money = Mathf.Max(money, GameParameter.MONEY_MIN);
        moneyUIDraw();
    }
}
