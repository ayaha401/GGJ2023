using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public enum GameFlow
    //{
    //    TitleInit,
    //    Title,
    //    TitleEnd,
    //    MainGame,
    //    Result,
    //}

    [SerializeField] private TitleManager titleManager;
    [SerializeField] private MainGameManager mainGameManager;

    private void Awake()
    {
        titleManager.EndTitle += MainGameStart;
    }

    public void MainGameStart(bool enable)
    {
        titleManager.titleEnable = false;
        mainGameManager.Init();
    }
}
