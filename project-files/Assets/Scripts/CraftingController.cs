using UnityEngine;
using System.Collections;

public class CraftingController : MonoBehaviour {


       

    void OnMouseDown()
    {
        if (GameController.waterCount > 0 && GameController.hopsCount > 0 && GameController.bottleCount > 0)
        {
            GameController.pissBeerCount++;
            GameController.waterCount--;
            GameController.hopsCount--;
            GameController.bottleCount--;
            PlayerProgressionScript.brewingExp++;
            Debug.Log("Beer count: " + GameController.pissBeerCount);
        }
        else
        {
            if (GameController.waterCount <= 0)
            {
                Debug.Log("Not enough water");
            }
            else
            {
                if (GameController.hopsCount <= 0)
                {
                    Debug.Log("Not enough hops");
                }else
                {
                    Debug.Log("Not enough bottles");
                }
            }
        }



 }



    string Message = "";


    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 30), Message);
    }


    void OnMouseEnter()
    {
        Message = "Craft your beer";
    }


    void OnMouseExit()
    {
        Message = "";
    }
}

