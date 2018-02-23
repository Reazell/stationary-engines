using UnityEngine;
using System.Collections;

public class BuyBottleScript : MonoBehaviour
{



    public static SpriteRenderer renderer;
    public static BoxCollider2D collider;
    // Use this for initialization
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        collider = GetComponent<BoxCollider2D>();
        renderer.enabled = false;
        collider.enabled = false;
    }

    void OnMouseDown()
    {
        if (GameController.moneyCount <= 0)
        {
            Debug.Log("No money to buy bottles");
        }
        else
        {
            if (GameController.moneyCount > 0)
            {
                GameController.moneyCount = GameController.moneyCount - 2;
                GameController.bottleCount++;

                
                Debug.Log("Ilosc butelek :" + GameController.bottleCount);
                Debug.Log("Ilosc pinionca :" + GameController.moneyCount);
            }
        }

    }
}
