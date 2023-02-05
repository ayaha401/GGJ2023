using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CriWare;

public class UISound : MonoBehaviour
{
    CriAtomExPlayback pb_UI_touch;
    CriAtomExPlayback pb_UI_decision;

    public CriAtomSource uiTouchSoundSource;
    public CriAtomSource uiDecisionSoundSource;

    public void PlayUITouchSound()
    {
        pb_UI_touch = uiTouchSoundSource.Play("UI_touch");
    }

    public void StopUITouchSound()
    {
        pb_UI_touch.Stop();
    }

    public void PlayUIDecisionSound()
    {
        pb_UI_decision = uiDecisionSoundSource.Play("UI_decision");
    }

    public void StopUIDecisionSound()
    {
        pb_UI_decision.Stop();
    }
}
