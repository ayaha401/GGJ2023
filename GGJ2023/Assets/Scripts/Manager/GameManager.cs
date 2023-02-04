using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public enum GameFlow
    {
        TitleInit,
        Title,
        TitleEnd,
        MainGame,
        Result,
    }

    private GameFlow currentGameFlow;
    [SerializeField] private TitleManager titleManager;

    [SerializeField] private Button button;

    void Start()
    {
        currentGameFlow = GameFlow.Title;
    }

    void Update()
    {
        
    }

    
}
