using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] GameObject player; //the player object

    void Start()
    {
        Vector3 playerPos = player.transform.position;
        //set the camera's position to the player's position
        transform.position = playerPos;
    }

    void Update()
    {
        Vector3 playerPos = player.transform.position;
        transform.position = playerPos;
    }
}