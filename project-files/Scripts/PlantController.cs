﻿using UnityEngine;
using System.Collections;

public class PlantController : MonoBehaviour
{
    public Sprite T_Grass;
    public  Sprite T_Dirt;
    public Sprite WetDirt;
    public Sprite T_Seed;
    public Sprite T_Seed_Wet;
    public Sprite Stage1;
    public Sprite Stage1_Wet;
    public Sprite Stage2;
    public Sprite HarvestReady;
    public Sprite HarvestReady_Wet;
    public SpriteRenderer[] spriteRenderer;




    bool isHarvestable = false;
    bool isStage1 = false;

    void OnMouseDown()
    {
        if (GameController.isTired == false)
        {

            if (GameController.currentTool == "hoe")
            {
                GetComponent<SpriteRenderer>().sprite = T_Dirt;
                GameController.energyValue--;
            }


            if (GameController.currentTool == "bucket")
            {
                if (GameController.waterCount > 0)
                {
                    if (GetComponent<SpriteRenderer>().sprite = T_Dirt)
                    {
                        GetComponent<SpriteRenderer>().sprite = WetDirt;
                        GameController.waterCount--;
                        GameController.energyValue--;
                    }
                }
            }

            if (GameController.currentTool == "seed")
            {
                if (GetComponent<SpriteRenderer>().sprite != WetDirt)
                {
                    Debug.Log("Not wet dirt");
                }
                else
                {
                    GetComponent<SpriteRenderer>().sprite = T_Seed_Wet;
                    Debug.Log("Seed planted");
                    Invoke("SpriteStage1", 5);
                    Invoke("SpriteHarvestReady", 10);

                }
            }


            if (isHarvestable == true)
            {
                GameController.hopsCount++;
                PlayerProgressionScript.harvestingExp++;
                Debug.Log("Hops: " + GameController.hopsCount);
                GetComponent<SpriteRenderer>().sprite = T_Grass;
                isHarvestable = false;
            }
        }
        else
        {
            Debug.Log("You are tired, go to sleep");
        }
    }
    
    

    void SpriteStage1()
    {
        GetComponent<SpriteRenderer>().sprite = Stage1_Wet;
        Debug.Log("Stage 1");
    }

    void SpriteHarvestReady()
    {
        GetComponent<SpriteRenderer>().sprite = HarvestReady_Wet;
        isHarvestable = true;
        Debug.Log("Harvest ready");
        
    }

    string Message = "";
    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 30), Message);
    }

    void OnMouseEnter()
    {
        Message = "Ground to plant seeds";
    }

    void OnMouseExit()
    {
        Message = "";
    }
}
