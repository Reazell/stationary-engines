using UnityEngine;
using System.Collections;

public class QuitGameScript : MonoBehaviour
{


    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }
}