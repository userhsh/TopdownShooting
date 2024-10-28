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
        ContinueButtonInit();
    }

    private void ButtonEventInit()
    {
        startSceneButtons.Buttons[0]?.onClick.AddListener(ContinueGame);
        startSceneButtons.Buttons[1]?.onClick.AddListener(NewGame);
        startSceneButtons.Buttons[3]?.onClick.AddListener(QuitGame);
    }

    // ����� �����Ͱ� �ִ��� Ȯ��
    private void CheckSaved()
    {
        // ���̺� ������ Ȯ�� ����

    }

    private void ContinueButtonInit() 
    {
        // ���̺� ������ Ȯ��
        CheckSaved();

        // ���̺갡 �ִٸ�
        if (isSaved)
        {
            // Continue button Ȱ��ȭ
            startSceneButtons.Buttons[0].interactable = true;
        }
        else // ���̺갡 ���ٸ�
        {
            // Continue button ��Ȱ��ȭ
            startSceneButtons.Buttons[0].interactable = false;
        }
    }

    private void ContinueGame()
    {
        //����� ������ �ҷ����� ����
        print("LoadGame");
        // ���Ӿ����� �̵�
        SceneManager.LoadScene(1);
    }

    private void NewGame()
    {
        // ���̺� ������ Ȯ��
        CheckSaved();

        // ���̺갡 �ִٸ�
        if (isSaved) 
        {
            // ����� ������ ����
            print("DeleteGame");
            // ���Ӿ����� �̵�
            SceneManager.LoadScene(1);
        }
        else // ���̺갡 ���ٸ�
        {
            // ���Ӿ����� �̵�
            SceneManager.LoadScene(1);
        }
    }

    private void QuitGame()
    {
        // ���� ���̺� ����
        print("SaveGame");
        // ���� ����
        Application.Quit();
    }
}