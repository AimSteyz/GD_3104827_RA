using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementScript : MonoBehaviour
{
    public GameObject groundCheck;

    // get the son object named HeroKnight_0
    public GameObject son;
    // get is animator
    public Animator animator;

    void Start()
    {
        // get the son object named HeroKnight_0
        son = GameObject.Find("HeroKnight_0");
        // get is animator
        animator = son.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 2);
            //make the player face left
            transform.localScale = new Vector3(-1, 1, 1);
        }
        // if right key is pressed move right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 2);
            //make the player face right
            transform.localScale = new Vector3(1, 1, 1);
        }
        // if space jump
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            //push the player up 2d rigidbody
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * 10, ForceMode2D.Impulse);
        }
        //if is grounded is true
        if (IsGrounded())
        {
            //set the animator isGrounded to true
            animator.SetBool("IsRunning", true);
        }
        else
        {
            //set the animator isGrounded to false
            animator.SetBool("IsRunning", false);
        }
    }

    private bool IsGrounded()
    {
        //if the boxcollider2d of the groundcheck object is colliding with something
        if (groundCheck.GetComponent<BoxCollider2D>().IsTouchingLayers())
        {
            Debug.Log("Grounded");
            return true;
        }
        else
        {
            Debug.Log("Not Grounded");
            return false;
        }
    }

}
