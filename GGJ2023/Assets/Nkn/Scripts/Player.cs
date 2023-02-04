using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField, Tooltip("草を抜けるドラッグの長さ")]
    private float canPullOutPower = 1;

    //[HideInInspector]
    public float clickRadius = 0.5f;

    // クリックしたところの座標
    Vector2 dragStartPos;
    List<Grass> clickGrasses = new List<Grass>();
    Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) MouseDown();
        if (Input.GetMouseButtonUp(0)) MouseUp();
    }

    /// <summary>
    /// クリックメソッド
    /// </summary>
    /// <returns>
    /// クリックしたオブジェクトを返す
    /// </returns>
    private void MouseDown()
    {
        // 開始位置の保存
        dragStartPos = GetMouseWorldPos();

        // レイで何に当たったか判断
        RaycastHit2D[] raycasts = Physics2D.CircleCastAll(dragStartPos, clickRadius, Vector2.zero);
        if (raycasts == null) return;

        foreach (var item in raycasts)
        {
            // 草をクリックした時の処理
            if (item.collider.TryGetComponent(out Grass grass))
            {
                // 保存
                clickGrasses.Add(grass);
            }

            //TODO:UIをクリックした時の処理も書く

        }

        Debug.Log($"範囲内の草の数:{clickGrasses.Capacity}");
    }

    /// <summary>
    /// クリックが離された時にドラッグのベクトルを求める
    /// </summary>
    private void MouseUp()
    {
        if (clickGrasses == null) return;

        Vector2 dragEndPos = GetMouseWorldPos();

        // ドラッグの開始位置と終了位置からベクトルを計算
        Vector2 dragVec = dragEndPos - dragStartPos;
        float dragPower = dragVec.magnitude;
        // ドラッグベクトルの表示
        Debug.DrawLine(dragStartPos, dragEndPos);
        // 上180° = ベクトルのYが0より大きい
        // ドラッグが
        bool canPullOut = dragVec.y > 0
                       && dragPower >= canPullOutPower;

        if (!canPullOut) return;
        // 草を抜く
        foreach (var grass in clickGrasses)
        {
            grass.PullOut();
        }

        clickGrasses.Clear();
    }

    private Vector2 GetMouseWorldPos()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector2 worldPos = mainCamera.ScreenToWorldPoint(mousePos);
        return worldPos;
    }
}