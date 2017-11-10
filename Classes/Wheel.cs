using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[ExecuteInEditMode]

public class Wheel : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        RotationCheck();

    }


    void RotationCheck()
    {
        float check1 = 0;
        float check2 = 36;
        int wynik = 0;
        for (int i = 0; i < 10; i++)
        {
            float rotationCheck = gameObject.transform.rotation.eulerAngles.z;

            if (rotationCheck > check1 && rotationCheck < check2)
            {
                Debug.Log("wynik 1" + wynik);
            }

            check1 = check1 + 36;
            check2 = check2 + 36;
            wynik = wynik + 1;
            if (wynik == 10)
            {
                wynik = 0;
            }


        }
    }

}

