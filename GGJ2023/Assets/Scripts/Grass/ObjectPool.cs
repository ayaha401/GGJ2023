using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField]
    GameObject grassPrefab;

    [SerializeField]
    Money money;

    List<GameObject> grasses = new List<GameObject>();

    Vector2 defaultPos = new Vector2(200, 200);

    const float insPosXMin = -7.8f;
    const float insPosXMax = 2.08f;
    const float insPosYMin = -3.47f;
    const float insPosYMax = 2.08f;

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
            }

            Vector2 insPos;
            insPos.x = Random.Range(insPosXMin, insPosXMax);
            insPos.y = Random.Range(insPosYMin, insPosYMax);

            inactiveObj.transform.position = insPos;
            // 強さの設定
            inactiveObj.GetComponent<Grass>().Setlevel(Random.Range(1, 4));
            inactiveObj.SetActive(true);
        }
    }
}