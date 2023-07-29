using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : MonoBehaviour
{
    // get the int score in the Sphere object
    public GameObject sphere;
    public int score = 0;

    void Start()
    {
        sphere = GameObject.Find("Sphere");
    }

    void Update()
    {
        // get the score from the Sphere object
        score = sphere.GetComponent<scr>().score;
        // print the score
        print("Score: " + score);
        // set the score value to the text in the Score object
        GetComponent<TextMesh>().text = "Score: " + score;
    }
}
