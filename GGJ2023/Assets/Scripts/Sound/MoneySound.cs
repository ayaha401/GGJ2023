using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CriWare;

public class MoneySound : MonoBehaviour
{
    CriAtomExPlayback pb_Money;

    public CriAtomSource moneySoundSource;

    /// <summary>
    /// クリアサウンドを出す
    /// </summary>
    public void PlayMoneySound()
    {
        pb_Money = moneySoundSource.Play("Money_Get");
    }

    public void StopMoneySound()
    {
        pb_Money.Stop();
    }
}
