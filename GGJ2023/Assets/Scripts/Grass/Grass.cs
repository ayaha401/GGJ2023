using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    [HideInInspector]
    public int level = 1;

    [SerializeField]
    Sprite[] grassSprite;


    const int MAX_LEVEL = 3;
    const int MIN_LEVEL = 1;


    ObjectPool objectPool;

    [SerializeField]
    SpriteRenderer spriteRenderer;
    Money money;

    void Start()
    {
        objectPool = transform.GetComponentInParent<ObjectPool>();
    }

    /// <summary>
    /// 草が抜けるメソッド
    /// </summary>
    public void PullOut()
    {
        int moneyValue;
        switch (level)
        {
            case 1:
                moneyValue = GameParameter.level1MoneyValue;
                break;
            case 2:
                moneyValue = GameParameter.level2MoneyValue;
                break;
            case 3:
                moneyValue = GameParameter.level3MoneyValue;
                break;
            default:
                moneyValue = 0;
                break;
        }

        objectPool.MovingToPool(gameObject);
        money.Plus(moneyValue);
    }

    public void Setlevel(int level)
    {
        // 不正な値の防止
        this.level = Mathf.Clamp(level, MIN_LEVEL, MAX_LEVEL);
        spriteRenderer.sprite = grassSprite[level - 1];
        // 草の大きさを調整
        transform.localScale = new Vector3(GameParameter.scaleValue[level - 1], GameParameter.scaleValue[level - 1], GameParameter.scaleValue[level - 1]);
    }

    public void SetMoney(Money money)
    {
        this.money = money;
    }
}