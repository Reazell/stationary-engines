using UnityEngine;
using System.Collections;

public class ScriptSeed : MonoBehaviour
{
    void OnMouseDown()
    {
        GameController.currentTool = "seed";
        Debug.Log(GameController.currentTool);
    }
}
