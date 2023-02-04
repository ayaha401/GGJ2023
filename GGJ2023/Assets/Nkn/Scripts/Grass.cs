using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    [Range(1, 3)]
    public int level = 1;

    [SerializeField]
    private int level1MoneyValue;

    [SerializeField]
    private int level2MoneyValue;

    [SerializeField]
    private int level3MoneyValue;

    const int MAX_LEVEL = 3;
    const int MIN_LEVEL = 1;


    Test_ObjectPool objectPool;

    Money money;

    void Start()
    {
        objectPool = transform.GetComponentInParent<Test_ObjectPool>();
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
        // 不正な値の防止
        this.level = Mathf.Clamp(level, MIN_LEVEL, MAX_LEVEL);
    }

    public void SetMoney(Money money)
    {
        this.money = money;
    }
}