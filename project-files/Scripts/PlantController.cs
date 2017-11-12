using UnityEngine;
using System.Collections;

public class PlantController : MonoBehaviour
{

    public Sprite T_Grass;
    public Sprite T_Dirt;
    public Sprite T_Seed;
    public Sprite Stage1;
    public Sprite Stage2;
    public Sprite ReadyHarvest;
    public SpriteRenderer[] spriteRenderer;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnMouseDown()
    {

        if (GameController.currentTool == "hoe")
        {
            GetComponent<SpriteRenderer>().sprite = T_Dirt;
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

            }
        }

        //if (GetComponent<SpriteRenderer>().sprite = ReadyHarvest)
        //{
        //    GameController.hopsCount++;
        //    Debug.Log(GameController.hopsCount);
        //    GetComponent<SpriteRenderer>().sprite = T_Dirt;
        //}
    }
}
