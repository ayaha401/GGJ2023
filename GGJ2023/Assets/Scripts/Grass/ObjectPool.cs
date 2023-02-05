using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField]
    GameObject grassPrefab;

    [SerializeField]
    Money money;

    [SerializeField, Tooltip("�v�[���ɐ������鐔")]
    private int InstantiateCount = 50;

    List<GameObject> grasses = new List<GameObject>();

    Vector2 defaultPos = new Vector2(200, 200);

    const float insPosXMin = -7.8f;
    const float insPosXMax = 2.08f;
    const float insPosYMin = -3.47f;
    const float insPosYMax = 2.08f;

    private void Start()
    {
        // �v�[���p�̃I�u�W�F�N�g�𐶐�
        InstantiateObj(InstantiateCount);
    }

    /// <summary>
    /// �I�u�W�F�N�g�����ۂɐ������郁�\�b�h
    /// </summary>
    /// <param name="count"></param>
    public void InstantiateObj(int count = 5)
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
                return;
            }

            Vector2 insPos;
            insPos.x = Random.Range(insPosXMin, insPosXMax);
            insPos.y = Random.Range(insPosYMin, insPosYMax);

            inactiveObj.transform.position = insPos;
            // �����̐ݒ�
            inactiveObj.GetComponent<Grass>().Setlevel(Random.Range(1, 4));
            inactiveObj.SetActive(true);
        }
    }

    /// <summary>
    /// ������ �S�Ă̑����v�[���ɖ߂�
    /// </summary>
    public void RemoveGrass()
    {
        foreach (var item in grasses)
        {
            Debug.Log("����");
            item.transform.position = defaultPos;
            item.SetActive(false);

        }
    }
}