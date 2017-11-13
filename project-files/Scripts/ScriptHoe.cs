using UnityEngine;
using System.Collections;

public class ScriptHoe : MonoBehaviour
{
    void OnMouseDown()
    {
        GameController.currentTool = "hoe";
        Debug.Log(GameController.currentTool);
    }
}
