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
        // ���� ���� ������ �̵�
        SceneManager.LoadScene(0);
    }

    private void StartGame()
    {
        // ���� ������ �̵�
        SceneManager.LoadScene(1);
    }

    private void ResetUpgrade()
    {
        // ��ȭ ���� �ʱ�ȭ
        print("Reset Upgrade");
        // �Ҹ� ��� ȯ��
        print("Gold Return");
    }
}