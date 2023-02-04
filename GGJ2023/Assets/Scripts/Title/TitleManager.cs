using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    [SerializeField] private GameObject titleObj;
    
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
    }

}
