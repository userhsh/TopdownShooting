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
        //����� ������ �ҷ����� ����
        print("LoadGame");
        // ���Ӿ����� �̵�
        SceneManager.LoadScene(1);
    }

    private void UpgradeScene()
    {
        // ���׷��̵� ������ �̵�
        SceneManager.LoadScene(2);
    }

    private void QuitGame()
    {
        // ���� ���̺� ����
        print("SaveGame");
        // ���� ����
        Application.Quit();
    }
}