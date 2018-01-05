using UnityEngine;
using System.Collections;

public class OpenStoreScript : MonoBehaviour {

    void OnMouseDown()
    {
        if (StoreScript.storeWindow.enabled == false)
        {
            StoreScript.storeWindow.enabled = true;
            StoreCloseScript.closeButtonCollider.enabled = true;
            StoreCloseScript.closeButtonSprite.enabled = true;
            SellBottleScript.collider.enabled = true;
            SellBottleScript.renderer.enabled = true;
            BuyBottleScript.collider.enabled = true;
            BuyBottleScript.renderer.enabled = true;
            BuyHopsScript.renderer.enabled = true;
            BuyHopsScript.collider.enabled = true;
            SellHopsScript.renderer.enabled = true;
            SellHopsScript.collider.enabled = true;
            SellBeerScript.renderer.enabled = true;
            SellBeerScript.collider.enabled = true;
        }
        else
        {
        if (StoreScript.storeWindow.enabled == true)
            {
                StoreScript.storeWindow.enabled = false;
                StoreCloseScript.closeButtonCollider.enabled = false;
                StoreCloseScript.closeButtonSprite.enabled = false;
                SellBottleScript.collider.enabled = false;
                SellBottleScript.renderer.enabled = false;
                BuyBottleScript.collider.enabled = false;
                BuyBottleScript.renderer.enabled = false;
                BuyHopsScript.renderer.enabled = false;
                BuyHopsScript.collider.enabled = false;
                SellHopsScript.renderer.enabled = false;
                SellHopsScript.collider.enabled = false;
                SellBeerScript.renderer.enabled = false;
                SellBeerScript.collider.enabled = false;
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
        Message = "Store";
    }


    void OnMouseExit()
    {
        Message = "";
    }
}
