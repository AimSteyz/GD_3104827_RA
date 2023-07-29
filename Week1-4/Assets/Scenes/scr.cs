using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{

    //import landing cube object
    public GameObject landingCube;
    // get the score int in the Score object
    public int score = 0;
    void Start()
    {
        landingCube = GameObject.Find("landing");
    }

    // Update is called once per frame
    void Update()
    {
        // print("SPHERE " + transform.position.z);
        // print("LANDING " + landingCube.transform.position.z);
        // print("LANDING2 " + (landingCube.transform.position.z - 0.05f));
        //if the sphere position is just on the landing cube position print "on the landing cube" z axis is 0.5f
        // print ("SPHERE " + transform.position.y + " LANDING " + (landingCube.transform.position.y+1f));
        if (transform.position.y <= (landingCube.transform.position.y +1.1f))
        {
            score = score + 1;
            // print("on the landing cube");
            // place the sphere at x = 0.13 y = 4.062 z = 3.43
            transform.position = new Vector3(0.13f, 4.062f, 3.43f);
            // print ("Score: " + score);
        }
    }
}
