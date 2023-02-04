using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainGameManager : MonoBehaviour
{
    [SerializeField] private Money money;
    [SerializeField] private Timer timer;
    [SerializeField] private Upgrade upgrade;

    public bool gameUpdatable = false;

    public Action EndMainGame;

    public void Init()
    {
        Debug.Log("メインゲーム");
        gameUpdatable = true;
        money.changeable = true;
        timer.changeable = true;
        money.Init();
        timer.Init();
        upgrade.Init();
    }

    private void Update()
    {
        if (!gameUpdatable) return;
        if (timer.CheckTimeUp())
        {
            Debug.Log("タイムアップ");
            EndMainGame();
        }
    }
}
