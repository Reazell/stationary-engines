using UnityEngine;
using System.Collections;

public class SellBeerScript : MonoBehaviour
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
        if (GameController.pissBeerCount == 0)
        {
            Debug.Log("No beer to sell");
        }
        else
        {
            if (GameController.pissBeerCount > 0)
            {
                GameController.pissBeerCount--;
                GameController.moneyCount = GameController.moneyCount + GameController.pissBeerValue;
                Debug.Log("Ilosc piwa :" + GameController.pissBeerCount);
                Debug.Log("Ilosc pinionca :" + GameController.moneyCount);
            }
        }
    }
}
