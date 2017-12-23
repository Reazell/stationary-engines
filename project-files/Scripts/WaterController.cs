using UnityEngine;
using System.Collections;

public class WaterController : MonoBehaviour
{

    void OnMouseDown()
    {
        if (GameController.currentTool == "bucket")
        {
            GameController.waterCount++;
            Debug.Log("Water : " + GameController.waterCount);
        }
    }

    string Message = "";


    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 30), Message);
    }


    void OnMouseEnter()
    {
        Message = "Water";
    }


    void OnMouseExit()
    {
        Message = "";
    }
}
