using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    GameStateUI gameStateUI = null;
    OptionSettingUI optionSettingUI = null;
    GameOverUI gameOverUI = null;

    private void Awake()
    {
        UIManagerInit();
    }

    private void UIManagerInit()
    {
        gameStateUI = GetComponentInChildren<GameStateUI>();
        optionSettingUI = GetComponentInChildren<OptionSettingUI>();
        gameOverUI = GetComponentInChildren<GameOverUI>();

        optionSettingUI.gameObject.SetActive(false);
        gameOverUI.gameObject.SetActive(false);
    }
}