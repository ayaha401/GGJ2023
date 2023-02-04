using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    [Range(1, 3)]
    public int level = 1;
    const int MAX_LEVEL = 3;
    const int MIN_LEVEL = 1;

    Test_ObjectPool objectPool;

    void Start()
    {
        objectPool = transform.GetComponentInParent<Test_ObjectPool>();
    }

    /// <summary>
    /// ���������郁�\�b�h
    /// </summary>
    public void PullOut()
    {
        Debug.Log("��������", gameObject);
        objectPool.MovingToPool(gameObject);
    }

    public void Setlevel(int level)
    {
        // �s���Ȓl�̖h�~
        this.level = Mathf.Clamp(level, MIN_LEVEL, MAX_LEVEL);
    }
}