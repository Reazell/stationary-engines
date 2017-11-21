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
}
