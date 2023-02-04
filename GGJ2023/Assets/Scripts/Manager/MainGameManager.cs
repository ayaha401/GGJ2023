using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameManager : MonoBehaviour
{
    [SerializeField] private Money money;

    public void Init()
    {
        Debug.Log("メインゲーム");
        money.changeable = true;
        money.Init();
    }
}
