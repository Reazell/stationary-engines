using UnityEngine;
using System.Collections;

public class SellScript : MonoBehaviour {

    void OnMouseDown()
    {
        if (GameController.pissBeerCount == 0)
        {
            Debug.Log("Nothing to sell");
        }
        else
        {
            if (GameController.pissBeerCount > 0)
            {


                GameController.moneyCount = GameController.pissBeerCount * (GameController.pissBeerValue + (GameController.pissBeerValue * PlayerProgressionScript.brewingBonus));
                GameController.pissBeerCount = 0;
                Debug.Log("Ilosc sikaczy :" + GameController.pissBeerCount);
                Debug.Log("Hajsung :" + GameController.moneyCount);

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
        Message = "Sell all beer";
    }


    void OnMouseExit()
    {
        Message = "";
    }
}
