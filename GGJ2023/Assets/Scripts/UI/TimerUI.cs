using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private Image dayAndNightImage;

    private float limitMaxTime;
    private const float ROTATE_ANGLE = 180f;
    

    private void Awake()
    {
        limitMaxTime = GameParameter.TIME_LIMIT;
        timer.timerUIDraw += DrawUI;
    }

    /// <summary>
    /// UIÇâÒì]Ç≥ÇπÇÈ
    /// </summary>
    /// <param name="currentTime">åªç›ÇÃéûä‘</param>
    private void DrawUI(float currentTime)
    {
        float leftTime = limitMaxTime - currentTime;
        float timeRatio = leftTime / limitMaxTime;
        dayAndNightImage.transform.eulerAngles = new Vector3(0f, 0f, -ROTATE_ANGLE * timeRatio);
    }
}
