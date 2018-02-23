using UnityEngine;
using System.Collections;

public class BuyHopsScript : MonoBehaviour
{
    public static SpriteRenderer renderer;
    public static BoxCollider2D collider;
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
            Debug.Log("No money to buy hops");
        }
        else
        {
            if (GameController.moneyCount > 0)
            {
                GameController.moneyCount = GameController.moneyCount - 2;
                GameController.hopsCount++;


                Debug.Log("Ilosc chmielu :" + GameController.hopsCount);
                Debug.Log("Ilosc pinionca :" + GameController.moneyCount);
            }
        }

    }
}
