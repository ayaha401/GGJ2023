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
        Debug.Log("�^�C�g�����");
        titleObj.SetActive(true);
    }

    public void HideTitle()
    {
        Debug.Log("�^�C�g���I��");
        titleObj.SetActive(false);
    }

}
