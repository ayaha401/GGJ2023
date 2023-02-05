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
        // �����ŏ�����
        Debug.Log("���C���Q�[��");
        gameUpdatable = true;
        money.changeable = true;
        timer.changeable = true;
        money.Init();
        timer.Init();
        upgrade.Init();
        dayAndNightImage.enabled = true;
        dayAndNightMat.SetFloat("_Alpha", 0.5f);
        player.ResetStutus();

        // �Q�[����ʂɏo��
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
            // �����ŏI������
            sound.PlayClearSound();
            objectPool.RemoveGrass();
            money.scoreUIDraw();
            EndMainGame();
        }
    }
}
