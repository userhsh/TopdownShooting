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

    // 저장된 데이터가 있는지 확인
    private void CheckSaved()
    {
        // 세이브 데이터 확인 로직

    }

    private void ContinueButtonInit() 
    {
        // 세이브 데이터 확인
        CheckSaved();

        // 세이브가 있다면
        if (isSaved)
        {
            // Continue button 활성화
            startSceneButtons.Buttons[0].interactable = true;
        }
        else // 세이브가 없다면
        {
            // Continue button 비활성화
            startSceneButtons.Buttons[0].interactable = false;
        }
    }

    private void ContinueGame()
    {
        //저장된 데이터 불러오는 로직
        print("LoadGame");
        // 게임씬으로 이동
        SceneManager.LoadScene(1);
    }

    private void NewGame()
    {
        // 세이브 데이터 확인
        CheckSaved();

        // 세이브가 있다면
        if (isSaved) 
        {
            // 저장된 데이터 삭제
            print("DeleteGame");
            // 게임씬으로 이동
            SceneManager.LoadScene(1);
        }
        else // 세이브가 없다면
        {
            // 게임씬으로 이동
            SceneManager.LoadScene(1);
        }
    }

    private void QuitGame()
    {
        // 게임 세이브 로직
        print("SaveGame");
        // 게임 종료
        Application.Quit();
    }
}