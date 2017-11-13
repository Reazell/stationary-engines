using UnityEngine;
using System.Collections;

public class ScriptBucket : MonoBehaviour
{
    public Sprite isFull;
    public Sprite isEmpty;
    public SpriteRenderer[] spriteRenderer;


    void OnMouseDown()
    {
        GameController.currentTool = "bucket";
        Debug.Log(GameController.currentTool);
    }
}
