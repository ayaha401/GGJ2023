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
    /// メインゲーム開始
    /// </summary>
    public void MainGameStart()
    {
        titleManager.titleEnable = false;
        mainGameManager.Init();
    }

    /// <summary>
    /// メインゲーム終了
    /// </summary>
    public void MainGameEnd()
    {
        mainGameManager.gameUpdatable = false;
        resultManager.ShowResult();
    }

    /// <summary>
    /// ゲームリスタート
    /// </summary>
    public void GameReStart()
    {
        resultManager.HideResult();
        mainGameManager.Init();
    }
}
