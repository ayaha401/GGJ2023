using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MainGameManager : MonoBehaviour
{
    [SerializeField] private Money money;
    [SerializeField] private Timer timer;
    [SerializeField] private Upgrade upgrade;
    [SerializeField] private ObjectPool objectPool;
    [SerializeField] private ClearSound sound;
    [SerializeField] private Image dayAndNightImage;
    [SerializeField] private Player player;

    public bool gameUpdatable = false;

    public Action EndMainGame;

    private Material dayAndNightMat;

    private void Awake()
    {
        dayAndNightMat = dayAndNightImage.material;
        dayAndNightImage.enabled = false;
    }

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
        dayAndNightImage.enabled = true;
        dayAndNightMat.SetFloat("_Alpha", 0.5f);
        player.ResetStutus();

        // ゲーム画面に出す
        objectPool.GenerateGrass(GameParameter.GENERATECOUNT);
    }

    public void HideDayAndNight()
    {
        dayAndNightImage.enabled = false;
    }

    private void Update()
    {
        if (!gameUpdatable) return;
        if (timer.CheckTimeUp())
        {
            // ここで終了処理
            sound.PlayClearSound();
            objectPool.RemoveGrass();
            money.scoreUIDraw();
            EndMainGame();
        }
    }
}
