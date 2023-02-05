using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CriWare;

public class MoneySound : MonoBehaviour
{
    CriAtomExPlayback pb_Money;

    public CriAtomSource moneySoundSource;

    /// <summary>
    /// �N���A�T�E���h���o��
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
