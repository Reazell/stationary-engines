using UnityEngine;
using System.Collections;

public class ScriptHoe : MonoBehaviour
{
    void OnMouseDown()
    {
        GameController.currentTool = "hoe";
        Debug.Log(GameController.currentTool);
    }

    string Message = "";


    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 30), Message);
    }


    void OnMouseEnter()
    {
        Message = "Hoe tool";
    }


    void OnMouseExit()
    {
        Message = "";
    }
}
