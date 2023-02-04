using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusUI : MonoBehaviour
{
    [SerializeField] private Upgrade upgrade;
    [SerializeField] private Text gloveLevelUI;
    [SerializeField] private Text areaLevelUI;

    private void Awake()
    {
        upgrade.gloveUIDraw += DrawGloveLevelUI;
        upgrade.areaUIDraw += DrawAreaLevelUI;
    }

    private void DrawGloveLevelUI(int level)
    {
        gloveLevelUI.text = level.ToString();
    }

    private void DrawAreaLevelUI(int level)
    {
        areaLevelUI.text = level.ToString();
    }
}
