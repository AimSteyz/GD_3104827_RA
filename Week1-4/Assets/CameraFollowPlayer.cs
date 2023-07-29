using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    // get the camera object named Main Camera
    public GameObject camera;

    void Start()
    {
        // get the camera object named Main Camera
        camera = GameObject.Find("Main Camera");   
    }

    void Update()
    {
        // get the player object named Player
        GameObject player = GameObject.Find("PlayerObject");
        // get the player position
        Vector3 playerPosition = player.transform.position;
        // set the camera position to the player position
        camera.transform.position = new Vector3(playerPosition.x, playerPosition.y, -10);

    }
}
