using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    [SerializeField] private Money money;

    private int gloveLevel;
    public int gloveLevelProp => gloveLevel;
    private int areaLevel;
    public int areaLevelProp => areaLevel;

    private int[] glovePriceTable = new int[8]{100, 120, 140, 160, 180, 200, 400, 600};
    private int[] areaPriceTable = new int[8]{100, 120, 140, 160, 180, 200, 400, 600};

    /// <summary>
    /// 初期化
    /// </summary>
    public void Init()
    {
        gloveLevel = GameParameter.GLOVE_INIT_LEVEL;
        areaLevel = GameParameter.AREA_INIT_LEVEL;
    }

    /// <summary>
    /// 軍手をアップグレード
    /// </summary>
    public void UpgradeGlove()
    {
        int glovePrice = glovePriceTable[gloveLevel - 1];
        bool buyable = money.moneyProp >= glovePrice;
        bool notMaxLevel = gloveLevel < GameParameter.UPGRADE_MAX_LEVEL;
        if (buyable && notMaxLevel)
        {
            money.Minus(glovePrice);
            gloveLevel++;
        }
    }

    /// <summary>
    /// 一度に取れる範囲をアップグレード
    /// </summary>
    public void UpgradeArea()
    {
        int areaPrice = areaPriceTable[areaLevel - 1];
        bool buyable = money.moneyProp >= areaPrice;
        bool notMaxLevel = areaLevel < GameParameter.UPGRADE_MAX_LEVEL;
        if (buyable && notMaxLevel)
        {
            money.Minus(areaPrice);
            areaLevel++;
        }
    }
}
