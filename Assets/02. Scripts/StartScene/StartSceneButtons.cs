using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartSceneButtons : MonoBehaviour
{
    private Button[] buttons = null;
    public Button[] Buttons {  get { return buttons; } }

    public void ButtonsInit()
    {
        buttons = GetComponentsInChildren<Button>();
    }
}