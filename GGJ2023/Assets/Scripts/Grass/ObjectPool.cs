using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField]
    GameObject grassPrefab;

    [SerializeField]
    Money money;

    [SerializeField, Tooltip("プールに生成する数")]
    private int InstantiateCount = 50;

    List<GameObject> grasses = new List<GameObject>();

    Vector2 defaultPos = new Vector2(200, 200);

    const float insPosXMin = -7.8f;
    const float insPosXMax = 2.08f;
    const float insPosYMin = -3.47f;
    const float insPosYMax = 2.08f;

    private void Start()
    {
        // プール用のオブジェクトを生成
        InstantiateObj(InstantiateCount);
    }

    /// <summary>
    /// オブジェクトを実際に生成するメソッド
    /// </summary>
    /// <param name="count"></param>
    public void InstantiateObj(int count = 5)
    {
        // 世界の端にたくさん作る
        for (int i = 0; i < count; i++)
        {
            GameObject obj = Instantiate(grassPrefab, defaultPos, Quaternion.identity, gameObject.transform);
            grasses.Add(obj);
            obj.SetActive(false);
            Grass grass = obj.GetComponent<Grass>();
            grass.SetMoney(money);
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
                return;
            }

            Vector2 insPos;
            insPos.x = Random.Range(insPosXMin, insPosXMax);
            insPos.y = Random.Range(insPosYMin, insPosYMax);

            inactiveObj.transform.position = insPos;
            // 強さの設定
            int rndNum = Random.Range(1, 11);
            int level = rndNum <= 1 ? 3 : rndNum <= 5 ? 2 : 1;
            inactiveObj.GetComponent<Grass>().Setlevel(level);
            inactiveObj.SetActive(true);
        }
    }

    /// <summary>
    /// 除草剤 全ての草をプールに戻す
    /// </summary>
    public void RemoveGrass()
    {
        foreach (var item in grasses)
        {
            item.transform.position = defaultPos;
            item.SetActive(false);
        }
    }
}