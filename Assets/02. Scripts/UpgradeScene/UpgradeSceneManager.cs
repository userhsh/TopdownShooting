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
        gameButton.GameButton[2].onClick.AddListener(ResetUpgrade);
    }

    private void BackStartScene()
    {
        // 게임 시작 씬으로 이동
        SceneManager.LoadScene(0);
    }

    private void StartGame()
    {
        // 메인 씬으로 이동
        SceneManager.LoadScene(1);
    }

    private void ResetUpgrade()
    {
        // 강화 레벨 초기화
        print("Reset Upgrade");
        // 소모 골드 환급
        print("Gold Return");
    }
}