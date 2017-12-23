using UnityEngine;
using System.Collections;

public class StoreController : MonoBehaviour {

    public static SpriteRenderer storeIcon;

    void Start()
    {
        storeIcon = GetComponent<SpriteRenderer>();
        storeIcon.enabled = false;

    }

    void Update()
    {
        if (GameController.storeIsClicked == true)
        {
            storeIcon.enabled = true;
        }
    }

}
