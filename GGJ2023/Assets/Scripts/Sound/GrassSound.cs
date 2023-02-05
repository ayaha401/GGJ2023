using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CriWare;

public class GrassSound : MonoBehaviour
{
    CriAtomExPlayback pb_Touch;
    CriAtomExPlayback pb_Pullout;

    public CriAtomSource touchSoundSource;
    public CriAtomSource pulloutSoundSource;

    /// <summary>
    /// 草に触れた時のサウンド
    /// </summary>
    public void PlayTouchSound()
    {
        pb_Touch = touchSoundSource.Play("Weed_touch");
    }

    /// <summary>
    /// 触れた音を止める
    /// </summary>
    public void StopTouchSound()
    {
        pb_Touch.Stop();
    }

    /// <summary>
    /// 抜く時のサウンド
    /// </summary>
    public void PlayPulloutSound()
    {
        pb_Pullout = pulloutSoundSource.Play("Weed_pullout");
    }

    /// <summary>
    /// 抜いた音を止める
    /// </summary>
    public void StopPulloutSound()
    {
        pb_Pullout.Stop();
    }
}
