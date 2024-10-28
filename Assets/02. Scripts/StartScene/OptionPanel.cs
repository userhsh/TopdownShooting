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

        // �ɼ�â�� �ִ� ��ư�� ��������
        buttons = GetComponentsInChildren<Button>();

        // ��ư �̺�Ʈ ����
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
        // ���� ȭ�� ���¿� ���� �ؽ�Ʈ ǥ�� �ٲ��ֱ�
        if (viewValue == 0)
        {
            nowViewMode.GetComponent<Text>().text = "��üȭ��";
        }
        else
        {
            nowViewMode.GetComponent<Text>().text = "â���";
        }
    }
}