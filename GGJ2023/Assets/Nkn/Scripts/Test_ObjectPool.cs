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
    /// �I�u�W�F�N�g�����ۂɐ������郁�\�b�h
    /// </summary>
    /// <param name="count"></param>
    void InstantiateObj(int count = 5)
    {
        // ���E�̒[�ɂ���������
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
    /// �n���ꂽ�I�u�W�F�N�g���\���ɂ��ăv�[���̈ʒu�ɖ߂�
    /// </summary>
    /// <param name="gameObject"></param>
    public void MovingToPool(GameObject gameObject)
    {
        gameObject.transform.position = defaultPos;
        gameObject.SetActive(false);
        GenerateGrass();
    }

    /// <summary>
    /// ��\���̃I�u�W�F�N�g��T���ăQ�[����ʂɏo��
    /// </summary>
    /// <param name="count">
    /// ���ݏo����
    /// </param>
    public void GenerateGrass(int count = 1)
    {
        GameObject inactiveObj = null;

        for (int i = 0; i < count; i++)
        {
            // ��A�N�e�B�u�̃I�u�W�F�N�g��T��
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
                // ��������Ȃ��Ȃ����瑝�₷
                InstantiateObj(5);
                GenerateGrass(count);
            }

            Vector2 insPos;
            insPos.x = Random.Range(insPosXRangeMin, insPosXRangeMax);
            insPos.y = Random.Range(insPosYRangeMin, insPosYRangeMax);

            inactiveObj.transform.position = insPos;
            // �����̐ݒ�
            inactiveObj.GetComponent<Grass>().Setlevel(Random.Range(1, 4));
            inactiveObj.SetActive(true);
        }
    }
}