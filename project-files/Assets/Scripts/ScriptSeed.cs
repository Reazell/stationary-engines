using UnityEngine;
using System.Collections;

public class ScriptSeed : MonoBehaviour
{
    void OnMouseDown()
    {
        GameController.currentTool = "seed";
        Debug.Log(GameController.currentTool);
    }


 string Message = "";


 void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 30), Message);
    }


 void OnMouseEnter()
    {
        Message = "Seeds list";
    }


 void OnMouseExit()
    {
        Message = "";
    }
}
