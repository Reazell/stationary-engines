using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public static string currentTool = "none";
    public static string currentWindow = "none";
    public static int seedCount = 0;
    public static int hopsCount = 0;
    public static int waterCount = 0;
    public static int bottleCount = 10;
    public static int pissBeerCount = 0;
    public static int pissBeerValue = 10;
    public static int moneyCount = 0;

    public static bool storeIsClicked = false;
	// Use this for initialization
	void Start () {
        Debug.Log(bottleCount);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
