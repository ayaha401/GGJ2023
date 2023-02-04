using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    private int money;
    public int moneyProp => money;

    /// <summary>
    /// Š‹à‚ğ‰Šú‰»‚·‚é
    /// </summary>
    public void Init()
    {
        money = GameParameter.MONEY_INIT;
    }

    /// <summary>
    /// Š‹à‚ğ‰ÁZ
    /// </summary>
    /// <param name="value">‰ÁZ—Ê</param>
    public void Plus(int value)
    {
        money += value;
        money = Mathf.Min(money, GameParameter.MONEY_MAX);
    }

    /// <summary>
    /// Š‹à‚ğŒ¸‚ç‚·
    /// </summary>
    /// <param name="value">Œ¸‚ç‚·—Ê</param>
    public void Minus(int value)
    {
        money -= value;
        money = Mathf.Max(money, GameParameter.MONEY_MIN);
    }
}
