using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndmanager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
    }
}
