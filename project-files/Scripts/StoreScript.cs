using UnityEngine;
using System.Collections;

public class StoreScript : MonoBehaviour
{


   public static SpriteRenderer storeWindow;
    // Use this for initialization
    void Start()
    {
        storeWindow = GetComponent<SpriteRenderer>();
        storeWindow.enabled = false;
    }
}
	

