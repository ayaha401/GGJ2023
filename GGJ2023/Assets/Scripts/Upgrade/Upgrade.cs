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

    private int[] glovePriceTable = new int[8]{100, 120, 140, 160, 180, 200, 400, 600};
    private int[] areaPriceTable = new int[8]{100, 120, 140, 160, 180, 200, 400, 600};

    public Action<int> gloveUIDraw;
    public Action<int> areaUIDraw;

    public Action<int> glovePriceUIDraw;
    public Action<int> areaPriceUIDraw;
    public Action cannotBuyGlove;
    public Action cannotBuyArea;

    /// <summary>
    /// 初期化
    /// </summary>
    public void Init()
    {
        gloveLevel = GameParameter.GLOVE_INIT_LEVEL;
        areaLevel = GameParameter.AREA_INIT_LEVEL;

        gloveUIDraw(gloveLevel);
        areaUIDraw(areaLevel);

        int glovePrice = glovePriceTable[gloveLevel - 1];
        glovePriceUIDraw(glovePrice);
        int areaPrice = areaPriceTable[areaLevel - 1];
        areaPriceUIDraw(areaPrice);
    }

    /// <summary>
    /// 軍手をアップグレード
    /// </summary>
    public void UpgradeGlove()
    {
        if(gloveLevel == GameParameter.UPGRADE_MAX_LEVEL)
        {
            return;
        }

        int glovePrice = glovePriceTable[gloveLevel - 1];
        bool buyable = money.moneyProp >= glovePrice;
        bool notMaxLevel = gloveLevel < GameParameter.UPGRADE_MAX_LEVEL;
        if (buyable && notMaxLevel)
        {
            money.Minus(glovePrice);
            gloveLevel++;
            if(gloveLevel + 1 < GameParameter.UPGRADE_MAX_LEVEL)
            {
                glovePrice = glovePriceTable[gloveLevel - 1];
                gloveUIDraw(gloveLevel);
                glovePriceUIDraw(glovePrice);
            }
            else
            {
                gloveUIDraw(gloveLevel);
                cannotBuyGlove();
            }
        }
    }

    /// <summary>
    /// 一度に取れる範囲をアップグレード
    /// </summary>
    public void UpgradeArea()
    {
        if (areaLevel == GameParameter.UPGRADE_MAX_LEVEL)
        {
            return;
        }

        int areaPrice = areaPriceTable[areaLevel - 1];
        bool buyable = money.moneyProp >= areaPrice;
        bool notMaxLevel = areaLevel < GameParameter.UPGRADE_MAX_LEVEL;
        if (buyable && notMaxLevel)
        {
            money.Minus(areaPrice);
            areaLevel++;
            if(areaLevel + 1 < GameParameter.UPGRADE_MAX_LEVEL)
            {
                areaPrice = areaPriceTable[areaLevel - 1];
                areaUIDraw(areaLevel);
                areaPriceUIDraw(areaPrice);
            }
            else
            {
                areaUIDraw(areaLevel);
                cannotBuyArea();
            }
        }
    }
}
