using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPanel : MonoBehaviour
{
    private bool isSaved = false;
    public bool Issaved { get { return isSaved; } set { isSaved = value; } }

    private bool isTutorial = false;

    [HideInInspector]
    public StartSceneButtons startSceneButtons = null;

    public void MainPanelInit()
    {
        startSceneButtons = GetComponentInChildren<StartSceneButtons>();
        startSceneButtons.ButtonsInit();
        ButtonEventInit();
    }

    private void ButtonEventInit()
    {
        startSceneButtons.Buttons[0]?.onClick.AddListener(StartGame);
        startSceneButtons.Buttons[1]?.onClick.AddListener(UpgradeScene);
        startSceneButtons.Buttons[3]?.onClick.AddListener(QuitGame);
    }

    private void CheckSave()
    {
        // 저장된 데이터가 있는지 확인
    }

    private void CheckTutorial()
    {
        // 튜토리얼을 할 것인지 확인
    }

    private void StartGame()
    {
        CheckSave();

        // 세이브 데이터가 있다면
        if (isSaved)
        {
            // 게임씬으로 이동
            SceneManager.LoadScene(3);
        }
        // 세이브 데이터가 없다면
        else
        {
            // 튜토리얼을 할껀지 확인
            CheckTutorial();

            // 한다면
            if (isTutorial) 
            {
                // 튜토리얼 씬으로 이동
                SceneManager.LoadScene(1);
            }
            // 안한다면
            else
            {
                // 게임씬으로 이동
                SceneManager.LoadScene(3);
            }
        }
    }

    private void UpgradeScene()
    {
        // 업그레이드 씬으로 이동
        SceneManager.LoadScene(2);
    }

    private void QuitGame()
    {
        // 게임 세이브 로직
        print("SaveGame");
        // 게임 종료
        Application.Quit();
    }
}