using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameManager : MonoBehaviour
{
    [SerializeField] private Money money;

    public void Init()
    {
        Debug.Log("���C���Q�[��");
        money.changeable = true;
        money.Init();
    }
}
