using UnityEngine;
using System.Collections;

public class ScriptHoe : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        GameController.currentTool = "hoe";
        Debug.Log(GameController.currentTool);
    }
}
