using UnityEngine;
using System.Collections;

public class ScriptBucket : MonoBehaviour
{
    public Sprite isFull;
    public Sprite isEmpty;
    public SpriteRenderer[] spriteRenderer;
    
    void Update()
    {
        if (GameController.waterCount == 0)
        {
            GetComponent<SpriteRenderer>().sprite = isEmpty;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = isFull;
        }
        }
    

    void OnMouseDown()
    {
        GameController.currentTool = "bucket";
        Debug.Log(GameController.currentTool);
    }

    string Message = "";


    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 30), Message);
    }


    void OnMouseEnter()
    {
        Message = "Bucket Tool";
    }


    void OnMouseExit()
    {
        Message = "";
    }
}
