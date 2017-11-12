using UnityEngine;
using System.Collections;

public class ScriptSeed : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        GameController.currentTool = "seed";
        Debug.Log(GameController.currentTool);
    }
}
