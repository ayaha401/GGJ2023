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
    /// ���ɐG�ꂽ���̃T�E���h
    /// </summary>
    public void PlayTouchSound()
    {
        pb_Touch = touchSoundSource.Play("Weed_touch");
    }

    /// <summary>
    /// �G�ꂽ�����~�߂�
    /// </summary>
    public void StopTouchSound()
    {
        pb_Touch.Stop();
    }

    /// <summary>
    /// �������̃T�E���h
    /// </summary>
    public void PlayPulloutSound()
    {
        pb_Pullout = pulloutSoundSource.Play("Weed_pullout");
    }

    /// <summary>
    /// �����������~�߂�
    /// </summary>
    public void StopPulloutSound()
    {
        pb_Pullout.Stop();
    }
}
