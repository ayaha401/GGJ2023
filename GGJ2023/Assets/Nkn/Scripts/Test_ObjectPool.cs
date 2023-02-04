using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_ObjectPool : MonoBehaviour
{
    [SerializeField]
    private int generationCount = 50;

    [SerializeField]
    GameObject grassPrefab;

    [SerializeField]
    Money money;

    List<GameObject> grasses = new List<GameObject>();

    Vector2 defaultPos = new Vector2(200, 200);

    float insPosXRangeMin = -8;
    float insPosXRangeMax = 8;
    float insPosYRangeMin = -4;
    float insPosYRangeMax = 4;

    void Start()
    {
        InstantiateObj(generationCount);

        GenerateGrass(10);
    }

    /// <summary>
    /// オブジェクトを実際に生成するメソッド
    /// </summary>
    /// <param name="count"></param>
    void InstantiateObj(int count = 5)
    {
        // 世界の端にたくさん作る
        for (int i = 0; i < count; i++)
        {
            GameObject obj = Instantiate(grassPrefab, defaultPos, Quaternion.identity, gameObject.transform);
            grasses.Add(obj);
            obj.SetActive(false);
            obj.GetComponent<Grass>().SetMoney(money);
        }
    }

    /// <summary>
    /// 渡されたオブジェクトを非表示にしてプールの位置に戻す
    /// </summary>
    /// <param name="gameObject"></param>
    public void MovingToPool(GameObject gameObject)
    {
        gameObject.transform.position = defaultPos;
        gameObject.SetActive(false);
        GenerateGrass();
    }

    /// <summary>
    /// 非表示のオブジェクトを探してゲーム画面に出す
    /// </summary>
    /// <param name="count">
    /// 生み出す数
    /// </param>
    public void GenerateGrass(int count = 1)
    {
        GameObject inactiveObj = null;

        for (int i = 0; i < count; i++)
        {
            // 非アクティブのオブジェクトを探す
            try
            {
                foreach (var item in grasses)
                {
                    if (item.activeSelf) continue;
                    inactiveObj = item;
                    break;
                }
            }
            catch
            {
                // 数が足りなくなったら増やす
                InstantiateObj(5);
                GenerateGrass(count);
            }

            Vector2 insPos;
            insPos.x = Random.Range(insPosXRangeMin, insPosXRangeMax);
            insPos.y = Random.Range(insPosYRangeMin, insPosYRangeMax);

            inactiveObj.transform.position = insPos;
            inactiveObj.SetActive(true);
        }
    }
}