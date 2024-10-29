using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpgradeSceneManager : MonoBehaviour
{
    GameButtons gameButton = null;

    private void Awake()
    {
        UpgradeSceneManagerInit();
    }

    private void UpgradeSceneManagerInit()
    {
        gameButton = GetComponentInChildren<GameButtons>();
        gameButton.GameButtonsInit();

        ButtonEvent();
    }

    private void ButtonEvent()
    {
        gameButton.GameButton[0].onClick.AddListener(BackStartScene);
        gameButton.GameButton[1].onClick.AddListener(StartGame);
    }

    private void BackStartScene()
    {
        // ���� ���� ������ �̵�
        SceneManager.LoadScene(0);
    }

    private void StartGame()
    {
        // ���� ������ �̵�
        SceneManager.LoadScene(1);
    }
}