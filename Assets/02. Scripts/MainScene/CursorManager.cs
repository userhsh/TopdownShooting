using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    private Texture2D nomalCrosshairCursor = null;

    private void Awake()
    {
        CursorInit();
    }

    private void Start()
    {
        CursorSetting();
    }

    private void CursorInit()
    {
        nomalCrosshairCursor = Resources.Load("NomalCrosshair") as Texture2D;
    }

    private void CursorSetting()
    {
        Cursor.SetCursor(nomalCrosshairCursor, Vector2.zero, CursorMode.Auto);
        //Cursor.SetCursor(default, Vector2.zero, CursorMode.Auto);
    }
}