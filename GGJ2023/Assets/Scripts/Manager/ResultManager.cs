using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ResultManager : MonoBehaviour
{
    [SerializeField] private GameObject resultObj;
    [HideInInspector] public bool resultEnable = false;
    public Action EndResult;

    /// <summary>
    /// リザルト表示
    /// </summary>
    public void ShowResult()
    {
        Debug.Log("リザルト表示");
        resultObj.SetActive(true);
    }

    /// <summary>
    /// リザルト
    /// </summary>
    public void HideResult()
    {
        Debug.Log("リザルト非表示");
        resultObj.SetActive(false);
    }

    /// <summary>
    /// ゲーム終了
    /// </summary>
    public void GameExit()
    {
        Debug.Log("ゲーム終了");
        Application.Quit();
    }
}
