using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Upgrade : MonoBehaviour
{
    [SerializeField] private Money money;

    private int gloveLevel;
    public int gloveLevelProp => gloveLevel;
    private int areaLevel;
    public int areaLevelProp => areaLevel;

    public Action<int> gloveUIDraw;
    public Action<int> areaUIDraw;

    public Action<int> glovePriceUIDraw;
    public Action<int> areaPriceUIDraw;

    /// <summary>
    /// 初期化
    /// </summary>
    public void Init()
    {
        gloveLevel = GameParameter.GLOVE_INIT_LEVEL;
        areaLevel = GameParameter.AREA_INIT_LEVEL;

        gloveUIDraw(gloveLevel);
        areaUIDraw(areaLevel);

        int glovePrice = GameParameter.glovePriceTable[gloveLevel - 1];
        glovePriceUIDraw(glovePrice);
        int areaPrice = GameParameter.areaPriceTable[areaLevel - 1];
        areaPriceUIDraw(areaPrice);
    }

    /// <summary>
    /// 軍手をアップグレード
    /// </summary>
    public void UpgradeGlove()
    {
        int glovePrice = GameParameter.glovePriceTable[gloveLevel - 1];
        bool buyable = money.moneyProp >= glovePrice;
        bool notMaxLevel = gloveLevel < GameParameter.UPGRADE_MAX_LEVEL;
        if (buyable && notMaxLevel)
        {
            money.Minus(glovePrice);
            gloveLevel++;
            glovePrice = GameParameter.glovePriceTable[gloveLevel - 1];
            gloveUIDraw(gloveLevel);
            glovePriceUIDraw(glovePrice);
        }
    }

    /// <summary>
    /// 一度に取れる範囲をアップグレード
    /// </summary>
    public void UpgradeArea()
    {
        int areaPrice = GameParameter.areaPriceTable[areaLevel - 1];
        bool buyable = money.moneyProp >= areaPrice;
        bool notMaxLevel = areaLevel < GameParameter.UPGRADE_MAX_LEVEL;
        if (buyable && notMaxLevel)
        {
            money.Minus(areaPrice);
            areaLevel++;
            areaPrice = GameParameter.areaPriceTable[areaLevel - 1];
            areaUIDraw(areaLevel);
            areaPriceUIDraw(areaPrice);
        }
    }
}
