using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPanel : MonoBehaviour
{
    private bool isSaved = false;
    public bool Issaved { get { return isSaved; } set { isSaved = value; } }
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

    private void StartGame()
    {
        //저장된 데이터 불러오는 로직
        print("LoadGame");
        // 게임씬으로 이동
        SceneManager.LoadScene(1);
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