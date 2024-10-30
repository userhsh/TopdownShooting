using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour
{ 
    MainPanel mainPanel = null;
    OptionPanel optionPanel = null;

    bool isOption = false;

    private void Awake()
    {
        StartManagerInit();
    }

    private void StartManagerInit()
    {
        Screen.SetResolution(1920, 1080, true);

        mainPanel = GetComponentInChildren<MainPanel>();
        optionPanel = GetComponentInChildren<OptionPanel>();

        mainPanel.MainPanelInit();
        mainPanel.startSceneButtons.Buttons[2].onClick.AddListener(OnOption);
        optionPanel.OptionPanelInit();
        optionPanel.buttons[2].onClick.AddListener(OnOption);

        mainPanel.gameObject.SetActive(true);
        optionPanel.gameObject.SetActive(false);
    }

    private void OnOption()
    {
        // 可记芒 难林扁
        isOption = !isOption;

        if (isOption) 
        {
            mainPanel.gameObject.SetActive(false);
            optionPanel.gameObject.SetActive(true);
        }
        else
        {
            mainPanel.gameObject.SetActive(true);
            optionPanel.gameObject.SetActive(false);
        }
    }
}