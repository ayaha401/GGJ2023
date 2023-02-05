using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private float canPullOutPower = 1;

    [HideInInspector]
    public float clickAreaRadius = 0.5f;

    [SerializeField]
    Timer timer;

    [SerializeField]
    GameObject PullOutCircle;

    [SerializeField]
    Image image;

    [SerializeField]
    Sprite[] gloveSprites;

    [SerializeField]
    GrassSound grassSound;

    [SerializeField]
    Upgrade upgrade;

    // クリックしたところの座標
    Vector2 dragStartPos;
    List<Grass> clickGrasses = new List<Grass>();
    Camera mainCamera;

    bool flg;

    void Start()
    {
        mainCamera = Camera.main;
        AreaRender();
    }

    void Update()
    {
        Vector3 glovePos = Input.mousePosition;
        image.rectTransform.position = glovePos;

        if (!flg) return;

        GloveUpgrade(upgrade.gloveLevelProp);
        AreaUpgrade(upgrade.areaLevelProp);


        if (timer.onTimeUp)
        {
            PullOutCircle.SetActive(false);
            return;
        }

        PullOutCircle.transform.position = GetMouseWorldPos();

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
        PullOutCircle.SetActive(false);
        image.sprite = gloveSprites[1];
        // 開始位置の保存
        dragStartPos = GetMouseWorldPos();

        // レイで何に当たったか判断
        RaycastHit2D[] raycasts = Physics2D.CircleCastAll(dragStartPos, clickAreaRadius, Vector2.zero);
        if (raycasts == null) return;

        foreach (var item in raycasts)
        {
            // 草をクリックした時の処理
            if (item.collider.TryGetComponent(out Grass grass))
            {
                // 保存
                clickGrasses.Add(grass);
                grassSound.PlayTouchSound();
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
        PullOutCircle.SetActive(true);
        image.sprite = gloveSprites[0];
        if (clickGrasses == null) return;

        Vector2 dragEndPos = GetMouseWorldPos();

        // ドラッグの開始位置と終了位置からベクトルを計算
        Vector2 dragVec = dragEndPos - dragStartPos;
        float dragPower = dragVec.magnitude;
        // ドラッグベクトルの表示
        Debug.DrawLine(dragStartPos, dragEndPos);
        // 上180° = ベクトルのYが0より大きい
        // ドラッグが一定以上の長さならカウント
        bool canPullOut = dragVec.y > 0
                       && dragPower >= canPullOutPower;

        if (!canPullOut) return;
        // 草を抜く
        foreach (var grass in clickGrasses)
        {
            grass.PullOut(GameParameter.PlayerATK);
        }

        clickGrasses.Clear();
    }

    private Vector2 GetMouseWorldPos()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector2 worldPos = mainCamera.ScreenToWorldPoint(mousePos);
        return worldPos;
    }

    public void GloveUpgrade(int currentLevel)
    {
        Debug.Log(currentLevel);
        GameParameter.PlayerATK = 1 * GameParameter.glovePowerTable[currentLevel - 1];
    }

    public void AreaUpgrade(int currentLevel)
    {
        clickAreaRadius = 1 * GameParameter.areaPowerTable[currentLevel - 1];
        AreaRender();
    }

    // 除草範囲を調整
    void AreaRender()
    {
        PullOutCircle.transform.localScale = new Vector3(clickAreaRadius * 2, clickAreaRadius * 2, 1);
    }

    public void ResetStutus()
    {
        flg = true;
    }
}