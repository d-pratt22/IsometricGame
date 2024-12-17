using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInformation : MonoBehaviour
{
    public Texture2D enemyCursor;
    public Texture2D defaultCursor;

    private Vector2 cursorHotspot;

    void OnMouseEnter()
    {
        Cursor.SetCursor(enemyCursor, cursorHotspot, CursorMode.Auto);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(defaultCursor, cursorHotspot, CursorMode.Auto);
    }
}
