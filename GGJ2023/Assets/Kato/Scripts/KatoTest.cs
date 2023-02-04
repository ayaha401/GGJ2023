using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatoTest : MonoBehaviour
{
    [SerializeField] private Money money;
    void Start()
    {
        money.Init();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            money.Plus(100);
        }

        if (Input.GetMouseButtonDown(1))
        {
            money.Minus(100);
        }
    }
}
