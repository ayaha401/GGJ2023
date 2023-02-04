using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TitleManager : MonoBehaviour
{
    [SerializeField] private GameObject titleObj;

    [HideInInspector] public bool titleEnable = false;
    public Action EndTitle;

    public void ShowTitle()
    {
        Debug.Log("�^�C�g�����");
        titleObj.SetActive(true);
    }

    public void HideTitle()
    {
        Debug.Log("�^�C�g���I��");
        titleObj.SetActive(false);
        titleEnable = true;
        EndTitle();
    }
}
