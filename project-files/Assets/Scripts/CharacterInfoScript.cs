using UnityEngine;
using System.Collections;

public class CharacterInfoScript : MonoBehaviour {


        void OnMouseDown()
    {
        Debug.Log("Brewing exp : " + PlayerProgressionScript.brewingExp);
        Debug.Log("Harvesting exp : " + PlayerProgressionScript.harvestingExp);
        Debug.Log("Harvesting lvl : " + PlayerProgressionScript.harvestingLvl);
        Debug.Log("Brewing lvl : " + PlayerProgressionScript.brewingLvl);
        Debug.Log("Current brewing bonus: " + PlayerProgressionScript.brewingBonus);
        Debug.Log("Current harvesting bonus: " + PlayerProgressionScript.harvestingBonus);
        Debug.Log("Beer value : " + GameController.pissBeerValue);
    }
    string Message = "";
    string Message1 = "";
    string Message2 = "";
    string Message3 = "";
    string Message4 = "";


    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 30), Message3);
        GUI.Label(new Rect(10, 40, 200, 30), Message4);
    }

    void Update()
    {
        Message1 = "harvesting lvl : " + PlayerProgressionScript.harvestingLvl;
        Message2 = "brewing lvl : " + PlayerProgressionScript.brewingLvl;
    }
    void OnMouseEnter()
    {
        Message3 = Message1;
        Message4 = Message2;
       
    }


    void OnMouseExit()
    {
        Message1 = Message;
        Message2 = Message;
        Message3 = Message;
        Message4 = Message;
    }
}

