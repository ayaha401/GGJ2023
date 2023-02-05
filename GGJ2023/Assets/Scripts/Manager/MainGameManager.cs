using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainGameManager : MonoBehaviour
{
    [SerializeField] private Money money;
    [SerializeField] private Timer timer;
    [SerializeField] private Upgrade upgrade;
    [SerializeField] private ObjectPool objectPool;

    public bool gameUpdatable = false;

    public Action EndMainGame;

    [SerializeField, Tooltip("プールに生成する数")]
    private int InstantiateCount = 50;

    public void Init()
    {
        // ここで初期化
        Debug.Log("メインゲーム");
        gameUpdatable = true;
        money.changeable = true;
        timer.changeable = true;
        money.Init();
        timer.Init();
        upgrade.Init();

        // プール用のオブジェクトを生成
        objectPool.InstantiateObj(InstantiateCount);
        // ゲーム画面に出す
        objectPool.GenerateGrass(GameParameter.GENERATECOUNT);
    }

    private void Update()
    {
        if (!gameUpdatable) return;
        if (timer.CheckTimeUp())
        {
            // ここで終了処理
            Debug.Log("タイムアップ");
            EndMainGame();
        }
    }
}
