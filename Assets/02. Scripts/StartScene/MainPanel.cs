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
        // ����� �����Ͱ� �ִ��� Ȯ��
    }

    private void CheckTutorial()
    {
        // Ʃ�丮���� �� ������ Ȯ��
    }

    private void StartGame()
    {
        CheckSave();

        // ���̺� �����Ͱ� �ִٸ�
        if (isSaved)
        {
            // ���Ӿ����� �̵�
            SceneManager.LoadScene(3);
        }
        // ���̺� �����Ͱ� ���ٸ�
        else
        {
            // Ʃ�丮���� �Ҳ��� Ȯ��
            CheckTutorial();

            // �Ѵٸ�
            if (isTutorial) 
            {
                // Ʃ�丮�� ������ �̵�
                SceneManager.LoadScene(1);
            }
            // ���Ѵٸ�
            else
            {
                // ���Ӿ����� �̵�
                SceneManager.LoadScene(3);
            }
        }
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