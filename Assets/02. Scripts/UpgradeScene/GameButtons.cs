using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameButtons : MonoBehaviour
{
    Button[] gameButton = null;
    public Button[] GameButton {  get { return gameButton; } }

    public void GameButtonsInit()
    {
        gameButton = GetComponentsInChildren<Button>();
    }
}