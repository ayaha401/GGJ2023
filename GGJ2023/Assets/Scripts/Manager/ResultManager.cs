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
    /// ���U���g�\��
    /// </summary>
    public void ShowResult()
    {
        Debug.Log("���U���g�\��");
        resultObj.SetActive(true);
    }

    /// <summary>
    /// ���U���g
    /// </summary>
    public void HideResult()
    {
        Debug.Log("���U���g��\��");
        resultObj.SetActive(false);
    }

    /// <summary>
    /// �Q�[���I��
    /// </summary>
    public void GameExit()
    {
        Debug.Log("�Q�[���I��");
        Application.Quit();
    }
}
