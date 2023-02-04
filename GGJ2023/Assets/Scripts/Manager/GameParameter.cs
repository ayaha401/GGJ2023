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
    public static int MONEY_MAX = 10000;

    // 時間関係＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝
    
    /// <summary>
    /// 制限時間(秒)
    /// </summary>
    public static float TIME_LIMIT = 6f;

    // アップグレード関係＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

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

}
