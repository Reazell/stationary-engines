using UnityEngine;
using System.Collections;

public class PlayerProgressionScript : MonoBehaviour {

    public static int harvestingExp;
    public static int brewingExp;
    public static double brewingBonus;
    public static double harvestingBonus;
    public static int brewingLvl;
    public static int harvestingLvl;

	void Update () {
	    
        if (harvestingExp < 5)
        {
            harvestingBonus = 0;
            harvestingLvl = 1;
            
        }
        if (harvestingExp >= 5 && harvestingExp < 10)
        {
            harvestingBonus = 0.05;
            harvestingLvl = 2;
            GameController.maxEnergyValue = 30;
        }
        if (harvestingExp >=10 && harvestingExp < 25)
        {
            harvestingBonus = 0.1;
            harvestingLvl = 3;
            GameController.maxEnergyValue = 35;
        }

        if (brewingExp < 5)
        {
            brewingBonus = 0;
            brewingLvl = 1;
        }
        if (brewingExp >= 5 && brewingExp < 10)
        {
            brewingBonus = 0.05;
            brewingLvl = 2;
        }
        if (brewingExp >= 10 && brewingExp < 25)
        {
            brewingBonus = 0.1;
            brewingLvl = 3;
        }
    }
}
