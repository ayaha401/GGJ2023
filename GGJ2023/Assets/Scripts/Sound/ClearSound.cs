using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CriWare;

public class ClearSound : MonoBehaviour
{
    CriAtomExPlayback pb_Clear;

    public CriAtomSource clearSoundSource;

    /// <summary>
    /// クリアサウンドを出す
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
