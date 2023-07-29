using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScript : MonoBehaviour
{
    //get gameobject
    public GameObject player;
    public GameObject ShopTexture;
    public GameObject GameValue;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerTexture");    
        ShopTexture = GameObject.Find("ShopTexture");
        GameValue = GameObject.Find("GameLogic");
    }

    // Update is called once per frame
    void Update()
    {
        //if player capsule collide with shop mesh collider
        if (player.GetComponent<Collider>().bounds.Intersects(ShopTexture.GetComponent<Collider>().bounds))
        {
            //allow player to cross shop
            Physics.IgnoreCollision(player.GetComponent<Collider>(), ShopTexture.GetComponent<Collider>(), true);
            // if player press E
            if (Input.GetKeyDown(KeyCode.E))
            {
                //add money to player
                GameValue.GetComponent<GameValue>().moneyNumber += (10*GameValue.GetComponent<GameValue>().fishNumber);
                //reset fish number
                GameValue.GetComponent<GameValue>().fishNumber = 0;
            }
        }
        else
        {
        }
    }
}
