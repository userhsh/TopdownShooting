using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionPanel : MonoBehaviour
{
    [HideInInspector]
    public Button[] buttons = null;
    NowViewMode nowViewMode = null;

    private int viewValue = 0;

    public void OptionPanelInit()
    {
        nowViewMode = GetComponentInChildren<NowViewMode>();

        // 옵션창에 있는 버튼들 가져오기
        buttons = GetComponentsInChildren<Button>();

        // 버튼 이벤트 매핑
        buttons[0]?.onClick.AddListener(ChangeViewMode);
        buttons[1]?.onClick.AddListener(ChangeViewMode);
    }

    private void ChangeViewMode()
    {
        if (viewValue == 0) 
        {
            viewValue++; 
            Screen.SetResolution(1920, 1080, false);
        }
        else
        {
            viewValue--;
            Screen.SetResolution(1920, 1080, true);
        }

        PrintViewMode();
    }

    private void PrintViewMode()
    {
        // 현재 화면 상태에 따라 텍스트 표시 바꿔주기
        if (viewValue == 0)
        {
            nowViewMode.GetComponent<Text>().text = "전체화면";
        }
        else
        {
            nowViewMode.GetComponent<Text>().text = "창모드";
        }
    }
}