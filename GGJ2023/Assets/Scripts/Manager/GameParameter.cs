public static class GameParameter
{
    /// <summary>
    /// ���邭�Ȃ�܂ł̎���
    /// </summary>
    public static float fadeinTime = 0.5f;

    /// <summary>
    /// �Â��Ȃ邽�߂̎���
    /// </summary>
    public static float tadeoutTime = 0.5f;


    // �v���C���[�֌W��������������������������������������������������������

    /// <summary>
    /// �v���C���[�̍U����
    /// </summary>
    public static float PlayerATK = 1;


    // �����֌W��������������������������������������������������������

    /// <summary>
    /// �ŏ��̏�����
    /// </summary>
    public static int MONEY_INIT = 0;

    /// <summary>
    /// �����̍ŏ��l
    /// </summary>
    public static int MONEY_MIN = 0;

    /// <summary>
    /// �����̍ő�l
    /// </summary>
    public static int MONEY_MAX = 99999;

    /// <summary>
    /// �G���̒l�i
    /// </summary>
    public static int level1MoneyValue = 10;

    /// <summary>
    /// ����ۂۂ̒l�i
    /// </summary>
    public static int level2MoneyValue = 50;

    /// <summary>
    /// �L����炵�̒l�i
    /// </summary>
    public static int level3MoneyValue = 100;


    // ���Ԋ֌W����������������������������������������������������

    /// <summary>
    /// ��������(�b)
    /// </summary>
    public static float TIME_LIMIT = 60f;

    // �A�b�v�O���[�h�֌W������������������������������������������������������

    /// <summary>
    /// �R��̃A�b�v�O���[�h�̒l�i
    /// </summary>
    public static int[] glovePriceTable = new int[8] { 100, 120, 140, 160, 180, 200, 400, 600 };

    /// <summary>
    /// �R��̃A�b�v�O���[�h��
    /// </summary>
    public static float[] glovePowerTable = { 1.0f, 1.5f, 1.6f, 1.8f, 2.0f, 2.2f, 2.5f, 2.7f, 3.0f };

    /// <summary>
    /// �F�B�̃A�b�v�O���[�h�̒l�i
    /// </summary>
    public static int[] areaPriceTable = new int[8] { 100, 120, 140, 160, 180, 200, 400, 600 };

    /// <summary>
    /// �F�B�̃A�b�v�O���[�h��
    /// </summary>
    public static float[] areaPowerTable = { 1.0f, 1.3f, 1.5f, 1.7f, 1.9f, 2.0f, 2.3f, 2.4f, 2.5f };

    /// <summary>
    /// �R��̏������x��
    /// </summary>
    public static int GLOVE_INIT_LEVEL = 1;

    /// <summary>
    /// ��x�Ɏ��͈͂̏������x��
    /// </summary>
    public static int AREA_INIT_LEVEL = 1;

    /// <summary>
    /// �A�b�v�O���[�h�̍ő僌�x��
    /// </summary>
    public static int UPGRADE_MAX_LEVEL = 9;

    // ���֌W������������������������������������������������������

    /// <summary>
    /// �ŏ��ɐ������鐔
    /// </summary>
    public static int GENERATECOUNT = 10;

    /// <summary>
    /// ���̑傫��
    /// </summary>
    public static float[] scaleValue = { 0.8f, 1.0f, 1.2f };

    /// <summary>
    /// ���̑ϋv��
    /// </summary>
    public static int[] WeedHP = { 1, 3, 5 };
}