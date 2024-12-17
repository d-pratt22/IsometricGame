using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    [SerializeField] private Texture2D cursorTexture;

    private Vector2 cursorHotspot;

  /*  [Header("Cursors")]
    public Texture2D defaultTexture;
    public Texture2D attackTexture;*/


    void Start()
    {
        //cursorHotspot = new Vector2(cursorTexture.width / 2, cursorTexture.height / 2);
        Cursor.SetCursor(cursorTexture, cursorHotspot, CursorMode.Auto);
    }

    void OnMouseOver()
    {
       
    }
   
}
