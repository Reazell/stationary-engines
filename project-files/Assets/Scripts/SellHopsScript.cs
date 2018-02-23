using UnityEngine;
using System.Collections;

public class SellHopsScript : MonoBehaviour
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
        if (GameController.hopsCount == 0)
        {
            Debug.Log("No hops to sell");
        }
        else
        {
            if (GameController.hopsCount > 0)
            {
                GameController.hopsCount--;
                GameController.moneyCount++;
                Debug.Log("Ilosc chmielu :" + GameController.hopsCount);
                Debug.Log("Ilosc pinionca :" + GameController.moneyCount);
            }
        }

    }
}
