using UnityEngine;
using System.Collections;

public class PlantController : MonoBehaviour
{
    public Sprite T_Grass;
    public Sprite T_Dirt;
    public Sprite T_Seed;
    public Sprite WetDirt;
    public Sprite Stage1;
    public Sprite Stage2;
    public Sprite HarvestReady;
    public SpriteRenderer[] spriteRenderer;
    bool isHarvestable = false;
    bool isWatered = false;

    void OnMouseDown()
    {

        if (GameController.currentTool == "hoe")
        {
            GetComponent<SpriteRenderer>().sprite = T_Dirt;
        }


        if (GameController.currentTool == "bucket")
        {
            if (GetComponent<SpriteRenderer>().sprite != T_Dirt)
            {
                Debug.Log("not dirt");
            }
            else
            {
                if (isWatered == true)
                {
                    Debug.Log("already watered");
                }
                else
                {
                    if (GameController.waterCount == 0)
                    {
                        Debug.Log("bucket is empty");
                    }
                    else
                    {
                        GetComponent<SpriteRenderer>().sprite = WetDirt;
                        isWatered = true;
                        GameController.waterCount--;
                        Debug.Log(GameController.waterCount);
                    }
                }
            }

            if (GameController.currentTool == "seed")
            {
                if (GetComponent<SpriteRenderer>().sprite != T_Dirt)
                {
                    Debug.Log("Not dirt");
                }
                else
                {
                    GetComponent<SpriteRenderer>().sprite = T_Seed;
                    Debug.Log("Seed planted");
                    Invoke("SpriteStage1", 5);
                    Invoke("SpriteHarvestReady", 10);
                }
            }

            if (isHarvestable == true)
            {
                GameController.hopsCount++;
                Debug.Log("Hops: " + GameController.hopsCount);
                GetComponent<SpriteRenderer>().sprite = T_Grass;
            }
        }
    }

    void SpriteStage1()
    {
        GetComponent<SpriteRenderer>().sprite = Stage1;
        Debug.Log("Stage 1");
    }

    void SpriteHarvestReady()
    {
        GetComponent<SpriteRenderer>().sprite = HarvestReady;
        isHarvestable = true;
        Debug.Log("Harvest ready");
    }
}
