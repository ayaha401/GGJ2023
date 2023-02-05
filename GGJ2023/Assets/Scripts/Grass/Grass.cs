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

    float hitPoint;

    ObjectPool objectPool;

    [SerializeField]
    SpriteRenderer spriteRenderer;
    Money money;

    void Start()
    {
        objectPool = transform.GetComponentInParent<ObjectPool>();
    }

    /// <summary>
    /// ���������郁�\�b�h
    /// </summary>
    public void PullOut(float atk = 1)
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

        hitPoint -= atk;

        if (hitPoint > 0) return;

        objectPool.MovingToPool(gameObject);
        money.Plus(moneyValue);
    }

    public void Setlevel(int level)
    {
        // �s���Ȓl�̖h�~
        this.level = Mathf.Clamp(level, MIN_LEVEL, MAX_LEVEL);
        spriteRenderer.sprite = grassSprite[level - 1];
        // ���̑傫���𒲐�
        transform.localScale = new Vector3(GameParameter.scaleValue[level - 1], GameParameter.scaleValue[level - 1], GameParameter.scaleValue[level - 1]);

        hitPoint = GameParameter.WeedHP[level - 1];
    }

    public void SetMoney(Money money)
    {
        this.money = money;
    }
}