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
     // カーソルをウィンドウから出さない
    Screen.lockCursor = true;
    // カーソルを表示しない
    Screen.showCursor = false;
#endif
    }
}