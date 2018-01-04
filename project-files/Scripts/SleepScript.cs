using UnityEngine;
using System.Collections;

public class SleepScript : MonoBehaviour {

    void OnMouseDown()
    {
        GameController.energyValue = GameController.maxEnergyValue;
        GameController.currentDay++;

    }

}
