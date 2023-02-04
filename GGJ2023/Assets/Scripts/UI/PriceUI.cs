using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceUI : MonoBehaviour
{
    [SerializeField] private Upgrade upgrade;
    [SerializeField] private Text glovePriceUI;
    [SerializeField] private Text areaPriceUI;

    private void Awake()
    {
        upgrade.glovePriceUIDraw += DrawGlovePrice;
        upgrade.areaPriceUIDraw += DrawAreaPrice;
    }

    private void DrawGlovePrice(int price)
    {
        glovePriceUI.text = price.ToString();
    }

    private void DrawAreaPrice(int price)
    {
        areaPriceUI.text = price.ToString();
    }
}
