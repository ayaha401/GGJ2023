using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursolManager : MonoBehaviour
{
    public void NoCursol()
    {
#if UNITY_EDITOR
        return;
#else
     // �J�[�\�����E�B���h�E����o���Ȃ�
    Screen.lockCursor = true;
    // �J�[�\����\�����Ȃ�
    Screen.showCursor = false;
#endif
    }
}