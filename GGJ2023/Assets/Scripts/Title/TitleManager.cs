using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TitleManager : MonoBehaviour
{
    [SerializeField] private GameObject titleObj;

    [HideInInspector] public bool titleEnable = false;
    public Action<bool> EndTitle;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ShowTitle()
    {
        Debug.Log("タイトル画面");
        titleObj.SetActive(true);
    }

    public void HideTitle()
    {
        Debug.Log("タイトル終了");
        titleObj.SetActive(false);
        titleEnable = true;
        EndTitle(titleEnable);
    }

}
