using UnityEngine;
using System.Collections;

public class SellBottleScript : MonoBehaviour {


    public static SpriteRenderer renderer;
    public static BoxCollider2D collider;
	// Use this for initialization
	void Start () {
        renderer = GetComponent<SpriteRenderer>();
        collider = GetComponent<BoxCollider2D>();
        renderer.enabled = false;
        collider.enabled = false;
	}
	
    void OnMouseDown()
    {
        if (GameController.bottleCount == 0)
        {
            Debug.Log("No bottles to sell");
        }
        else
        {
            if(GameController.bottleCount > 0)
            {
                GameController.bottleCount--;
                GameController.moneyCount++;
                Debug.Log("Ilosc butelek :" + GameController.bottleCount);
                Debug.Log("Ilosc pinionca :" + GameController.moneyCount);
            }
        }

    }

	// Update is called once per frame
	void Update () {
	
	}
}
