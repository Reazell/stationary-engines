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
        }
	}
}
