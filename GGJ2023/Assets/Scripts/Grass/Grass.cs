using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    [HideInInspector]
    public int level = 1;

    [SerializeField]
    private int level1MoneyValue;

    [SerializeField]
    private int level2MoneyValue;

    [SerializeField]
    private int level3MoneyValue;

    [SerializeField]
    Sprite[] grassSprite;

    float[] scaleValue = { 0.8f, 1.0f, 1.2f };

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
    /// ���������郁�\�b�h
    /// </summary>
    public void PullOut()
    {
        int moneyValue;
        switch (level)
        {
            case 1:
                moneyValue = level1MoneyValue;
                break;
            case 2:
                moneyValue = level2MoneyValue;
                break;
            case 3:
                moneyValue = level3MoneyValue;
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
        // �s���Ȓl�̖h�~
        this.level = Mathf.Clamp(level, MIN_LEVEL, MAX_LEVEL);
        spriteRenderer.sprite = grassSprite[level - 1];
        // ���̑傫���𒲐�
        transform.localScale = new Vector3(scaleValue[level - 1], scaleValue[level - 1], scaleValue[level - 1]);
    }

    public void SetMoney(Money money)
    {
        this.money = money;
    }
}