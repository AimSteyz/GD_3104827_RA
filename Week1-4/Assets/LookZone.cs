using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookZone : MonoBehaviour
{
    [SerializeField] GameObject player; //the player object
    [SerializeField] GameObject EnemyTexture; //the look zone object
    [SerializeField] GameObject Enemy; //the enemy object

    void Start()
    {
        //set enemy texture color to red
        EnemyTexture.GetComponent<Renderer>().material.color = Color.red;
    }

    void Update() {
        //print player position
        Debug.Log(player.transform.position);

        // if player position enter the enemy capsule collider 3d then change the enemy texture color to green
        if (player.transform.position.x >= Enemy.transform.position.x - 4 && player.transform.position.x <= Enemy.transform.position.x + 4 && player.transform.position.z >= Enemy.transform.position.z - 4 && player.transform.position.z <= Enemy.transform.position.z + 4) {
            EnemyTexture.GetComponent<Renderer>().material.color = Color.green;
            // Look at the player and move towards the player
            Enemy.transform.LookAt(player.transform);
            Enemy.transform.position += Enemy.transform.forward * 0.006f;
        } else if (player.transform.position.x >= Enemy.transform.position.x - 8 && player.transform.position.x <= Enemy.transform.position.x + 8 && player.transform.position.z >= Enemy.transform.position.z - 8 && player.transform.position.z <= Enemy.transform.position.z + 8) {
            EnemyTexture.GetComponent<Renderer>().material.color = Color.yellow;
            // Look at the player
            Enemy.transform.LookAt(player.transform);
        } else {
            //else change the enemy texture color to red
            EnemyTexture.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}