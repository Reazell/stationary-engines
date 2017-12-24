using UnityEngine;
using System.Collections;

public class CharacterInfoScript : MonoBehaviour {


        void OnMouseDown()
    {
        Debug.Log(PlayerProgressionScript.brewingExp);
        Debug.Log(PlayerProgressionScript.harvestingExp);
        Debug.Log("Current brewing bonus: " + PlayerProgressionScript.brewingBonus);
        Debug.Log("Current harvesting bonus: " + PlayerProgressionScript.harvestingBonus);
    }
    static int harvestingLvl = PlayerProgressionScript.harvestingLvl;
    static int brewingLvl = PlayerProgressionScript.brewingLvl;

    string Message1 = "";
    string Message2 = "";
    string harvestingLvlCheck = harvestingLvl.ToString();
    string brewingLvlCheck = brewingLvl.ToString();

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 30), Message1);
        GUI.Label(new Rect(10, 40, 200, 30), Message2);
    }


    void OnMouseEnter()
    {
        Message1 = "harvesting lvl : " + harvestingLvlCheck;
        Message2 = "brewing lvl : " + brewingLvlCheck;
       
    }


    void OnMouseExit()
    {
        Message1 = "";
        Message2 = "";
    }
}

