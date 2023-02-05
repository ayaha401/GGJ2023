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
    [SerializeField] private ClearSound sound;

    public bool gameUpdatable = false;

    public Action EndMainGame;

    [SerializeField, Tooltip("�v�[���ɐ������鐔")]
    private int InstantiateCount = 50;

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

        // �v�[���p�̃I�u�W�F�N�g�𐶐�
        objectPool.InstantiateObj(InstantiateCount);
        // �Q�[����ʂɏo��
        objectPool.GenerateGrass(GameParameter.GENERATECOUNT);
    }

    private void Update()
    {
        if (!gameUpdatable) return;
        if (timer.CheckTimeUp())
        {
            // �����ŏI������
            sound.PlayClearSound();
            EndMainGame();
        }
    }
}
