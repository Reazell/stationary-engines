using UnityEngine;
using System.Collections;

public class StoreCloseScript : MonoBehaviour {
    public static SpriteRenderer closeButtonSprite;
    public static BoxCollider2D closeButtonCollider;
    // Use this for initialization
    void Start () {
        closeButtonSprite = GetComponent<SpriteRenderer>();
        closeButtonCollider = GetComponent<BoxCollider2D>();
        closeButtonSprite.enabled = false;
        closeButtonCollider.enabled = false;
	}
	
    void OnMouseDown()
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
        SellBeerScript.renderer.enabled = false;

    }

	// Update is called once per frame
	void Update () {
	
	}
}
