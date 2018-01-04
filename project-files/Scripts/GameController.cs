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
    public static double pissBeerValue = 10;
    public static double moneyCount = 0;
    string Message = "";
    string Message2 = "";
    string Message3 = "";
    public static int energyValue = 25;
    public static int maxEnergyValue = 25;
    public static int currentDay = 1;

    public static bool storeIsClicked = false;
	void Start ()
    {
        Debug.Log("Ilosc butelek: " + bottleCount);
	}

    void Update()
    {
        Message = "Ilosc pieniedzy : " + moneyCount + " Ilosc butelek : " + bottleCount + " Ilosc chmielu : " + hopsCount + " Ilosc piwa : " + pissBeerCount;
        Message2 = "Energy : " + energyValue + "/" + maxEnergyValue;
        Message3 = "Current day: " + currentDay;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(300, 10, 400, 200), Message);
        GUI.Label(new Rect(200, 10, 100, 40), Message2);
        GUI.Label(new Rect(200, 25, 100, 40), Message3);
    }



}
