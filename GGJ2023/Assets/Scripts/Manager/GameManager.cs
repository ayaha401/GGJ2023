using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TitleManager titleManager;
    [SerializeField] private MainGameManager mainGameManager;
    [SerializeField] private ResultManager resultManager;
    [SerializeField] private CursolManager cursolManager;

    private void Awake()
    {
        titleManager.EndTitle += MainGameStart;
        mainGameManager.EndMainGame += MainGameEnd;
    }

    private void Start()
    {
        resultManager.HideResult();
        cursolManager.NoCursol();
    }

    /// <summary>
    /// ���C���Q�[���J�n
    /// </summary>
    public void MainGameStart()
    {
        titleManager.titleEnable = false;
        mainGameManager.Init();
    }

    /// <summary>
    /// ���C���Q�[���I��
    /// </summary>
    public void MainGameEnd()
    {
        mainGameManager.gameUpdatable = false;
        mainGameManager.HideDayAndNight();
        resultManager.ShowResult();
    }

    /// <summary>
    /// �Q�[�����X�^�[�g
    /// </summary>
    public void GameReStart()
    {
        resultManager.HideResult();
        mainGameManager.Init();
    }
}
