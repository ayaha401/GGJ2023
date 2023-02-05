using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private Image dayAndNightImage;
    [SerializeField] private Image dayAndNightShadeImage;

    private float limitMaxTime;
    private const float ROTATE_ANGLE = 180f;

    private Material material;
    

    private void Awake()
    {
        limitMaxTime = GameParameter.TIME_LIMIT;
        timer.timerUIDraw += DrawUI;

        material = dayAndNightShadeImage.material;
    }

    /// <summary>
    /// UIÇâÒì]Ç≥ÇπÇÈ
    /// </summary>
    /// <param name="currentTime">åªç›ÇÃéûä‘</param>
    private void DrawUI(float currentTime)
    {
        float leftTime = limitMaxTime - currentTime;
        float timeRatio = leftTime / limitMaxTime;
        material.SetFloat("_CurrentTime", 1f - timeRatio);
        dayAndNightImage.transform.eulerAngles = new Vector3(0f, 0f, -ROTATE_ANGLE * timeRatio + 180f);
    }
}
