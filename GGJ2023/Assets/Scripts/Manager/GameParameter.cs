public static class GameParameter
{
    /// <summary>
    /// 明るくなるまでの時間
    /// </summary>
    public static float fadeinTime = 0.5f;

    /// <summary>
    /// 暗くなるための時間
    /// </summary>
    public static float tadeoutTime = 0.5f;


    // プレイヤー関係＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

    /// <summary>
    /// プレイヤーの攻撃力
    /// </summary>
    public static float PlayerATK = 1;


    // お金関係＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

    /// <summary>
    /// 最初の所持金
    /// </summary>
    public static int MONEY_INIT = 0;

    /// <summary>
    /// お金の最小値
    /// </summary>
    public static int MONEY_MIN = 0;

    /// <summary>
    /// お金の最大値
    /// </summary>
    public static int MONEY_MAX = 99999;

    /// <summary>
    /// 雑草の値段
    /// </summary>
    public static int level1MoneyValue = 10;

    /// <summary>
    /// たんぽぽの値段
    /// </summary>
    public static int level2MoneyValue = 50;

    /// <summary>
    /// 猫じゃらしの値段
    /// </summary>
    public static int level3MoneyValue = 100;


    // 時間関係＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

    /// <summary>
    /// 制限時間(秒)
    /// </summary>
    public static float TIME_LIMIT = 60f;

    // アップグレード関係＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

    /// <summary>
    /// 軍手のアップグレードの値段
    /// </summary>
    public static int[] glovePriceTable = new int[8] { 100, 120, 140, 160, 180, 200, 400, 600 };

    /// <summary>
    /// 軍手のアップグレード力
    /// </summary>
    public static float[] glovePowerTable = { 1.0f, 1.5f, 1.6f, 1.8f, 2.0f, 2.2f, 2.5f, 2.7f, 3.0f };

    /// <summary>
    /// 友達のアップグレードの値段
    /// </summary>
    public static int[] areaPriceTable = new int[8] { 100, 120, 140, 160, 180, 200, 400, 600 };

    /// <summary>
    /// 友達のアップグレード力
    /// </summary>
    public static float[] areaPowerTable = { 1.0f, 1.3f, 1.5f, 1.7f, 1.9f, 2.0f, 2.3f, 2.4f, 2.5f };

    /// <summary>
    /// 軍手の初期レベル
    /// </summary>
    public static int GLOVE_INIT_LEVEL = 1;

    /// <summary>
    /// 一度に取る範囲の初期レベル
    /// </summary>
    public static int AREA_INIT_LEVEL = 1;

    /// <summary>
    /// アップグレードの最大レベル
    /// </summary>
    public static int UPGRADE_MAX_LEVEL = 9;

    // 草関係＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

    /// <summary>
    /// 最初に生成する数
    /// </summary>
    public static int GENERATECOUNT = 10;

    /// <summary>
    /// 草の大きさ
    /// </summary>
    public static float[] scaleValue = { 0.8f, 1.0f, 1.2f };

    /// <summary>
    /// 草の耐久性
    /// </summary>
    public static int[] WeedHP = { 1, 3, 5 };
}