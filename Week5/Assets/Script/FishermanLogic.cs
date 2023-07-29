using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FishermanLogic : MonoBehaviour
{
    GameObject gameLogic;
    GameObject GameValue;
    GameObject PlayerTexture;
    GameObject fisherManTexture;
    GameObject FisherManDisplayText;
    TMP_Text FisherManDisplayTextText;

    int fishermanLevel;
    int[] FishermanPrice;
    int[] FishermanFishPerSecond;
    double playerMoney;

    void Start()
    {
        // get game object
        gameLogic = GameObject.Find("GameLogic");
        GameValue = GameObject.Find("GameValue");
        fisherManTexture = GameObject.Find("FisherManTexture");
        FisherManDisplayText = GameObject.Find("FisherManDisplayText");
        PlayerTexture = GameObject.Find("PlayerTexture");
        FisherManDisplayTextText = FisherManDisplayText.GetComponent<TMP_Text>();
        playerMoney = gameLogic.GetComponent<GameValue>().moneyNumber;
        Debug.Log(playerMoney);

        // set fisherman price and fish per second
        FishermanPrice = new int[10];
        FishermanPrice[0] = 100;
        FishermanPrice[1] = 500;
        FishermanPrice[2] = 1000;
        FishermanPrice[3] = 5000;
        FishermanPrice[4] = 10000;
        FishermanPrice[5] = 50000;
        FishermanPrice[6] = 100000;
        FishermanPrice[7] = 500000;
        FishermanPrice[8] = 1000000;
        FishermanPrice[9] = 5000000;

        FishermanFishPerSecond = new int[10];
        FishermanFishPerSecond[0] = 1;
        FishermanFishPerSecond[1] = 2;
        FishermanFishPerSecond[2] = 5;
        FishermanFishPerSecond[3] = 10;
        FishermanFishPerSecond[4] = 30;
        FishermanFishPerSecond[5] = 50;
        FishermanFishPerSecond[6] = 100;
        FishermanFishPerSecond[7] = 300;
        FishermanFishPerSecond[8] = 500;
        FishermanFishPerSecond[9] = 1000;


    }

    // Update is called once per frame
    void Update()
    {
        // get fisherman level
        fishermanLevel = gameLogic.GetComponent<GameValue>().fishermanLevel;
        playerMoney = gameLogic.GetComponent<GameValue>().moneyNumber;

        // display fisherman info
        FisherManDisplayTextText.text = "Fisherman Level: " + fishermanLevel + "\n" + "Upgrade Price: " + FishermanPrice[fishermanLevel] + "\n" + "Fish Per Second: " + FishermanFishPerSecond[fishermanLevel];

        // get player collider and fisherman collider and check if player collide with fisherman
        if (PlayerTexture.GetComponent<Collider>().bounds.Intersects(fisherManTexture.GetComponent<Collider>().bounds))
        {
            // allow player to cross fisherman
            Physics.IgnoreCollision(PlayerTexture.GetComponent<Collider>(), fisherManTexture.GetComponent<Collider>(), true);
            // if player press E
            if (Input.GetKeyDown(KeyCode.E))
            {
                // if player money is more than fisherman price
                if (playerMoney >= FishermanPrice[fishermanLevel])
                {
                    // upgrade fisherman
                    gameLogic.GetComponent<GameValue>().fishermanLevel += 1;
                    // deduct player money
                    gameLogic.GetComponent<GameValue>().moneyNumber -= FishermanPrice[fishermanLevel];
                    // set fisherman enable to true
                    gameLogic.GetComponent<GameValue>().isFishermanEnable = true;
                }
            }
        }



        //fisherman farm
        if (gameLogic.GetComponent<GameValue>().isFishermanEnable == true)
        {
            fisherManTexture.GetComponent<Renderer>().material.color = Color.green;
            switch (fishermanLevel)
            {
                case 0:
                    if (Time.frameCount % 500 == 0)
                    {
                        gameLogic.GetComponent<GameValue>().fishNumber += FishermanFishPerSecond[fishermanLevel];
                    }
                    break;
                case 1:
                    if (Time.frameCount % 500 == 0)
                    {
                        gameLogic.GetComponent<GameValue>().fishNumber += FishermanFishPerSecond[fishermanLevel];
                    }
                    break;
                case 2:
                    if (Time.frameCount % 500 == 0)
                    {
                        gameLogic.GetComponent<GameValue>().fishNumber += FishermanFishPerSecond[fishermanLevel];
                    }
                    break;
                case 3:
                    if (Time.frameCount % 500 == 0)
                    {
                        gameLogic.GetComponent<GameValue>().fishNumber += FishermanFishPerSecond[fishermanLevel];
                    }
                    break;
                case 4:
                    if (Time.frameCount % 500 == 0)
                    {
                        gameLogic.GetComponent<GameValue>().fishNumber += FishermanFishPerSecond[fishermanLevel];
                    }
                    break;
                default:
                    if (Time.frameCount % 500 == 0)
                    {
                        gameLogic.GetComponent<GameValue>().fishNumber += FishermanFishPerSecond[fishermanLevel];
                    }
                    break;
            }

        }
        else
        {
            fisherManTexture.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
