using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] Money money;
    [SerializeField] private Text scoreText;

    private void Awake()
    {
        money.scoreUIDraw += DrawUI;
    }

    private void DrawUI()
    {
        scoreText.text = money.moneyProp.ToString();
    }
}
