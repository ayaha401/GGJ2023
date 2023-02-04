using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
    [SerializeField] private Money money;
    [SerializeField] Text uiText;

    private void Awake()
    {
        money.moneyUIDraw += DrawUI;
    }

    private void DrawUI()
    {
        uiText.text = money.moneyProp.ToString();
    }
}
