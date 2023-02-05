using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CriWare;

public class ClearSound : MonoBehaviour
{
    CriAtomExPlayback pb_Clear;

    public CriAtomSource clearSoundSource;

    /// <summary>
    /// �N���A�T�E���h���o��
    /// </summary>
    public void PlayClearSound()
    {
        pb_Clear = clearSoundSource.Play("Clear");
    }

    public void StopClearSound()
    {
        pb_Clear.Stop();
    }
}
