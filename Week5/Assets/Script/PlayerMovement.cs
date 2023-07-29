using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    private Camera cam;

    private Ray ray;
    private RaycastHit hit;

    public Animator animator;

    private void Awake()
    {
        // get the animator component in the PlayerTexture child component
        animator = GetComponentInChildren<Animator>();

        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        cam = Camera.main;
    }

    private void Update()
    {


        // if scroll wheel is moving forward or backward then zoom in or out 
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, 40, Time.deltaTime * 50);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, 60, Time.deltaTime * 50);
        }


        if (agent.remainingDistance > agent.stoppingDistance)
        {
            // set isWalking to true
            animator.SetBool("isWalking", true);
        }
        else
        {
            // set isWalking to false
            animator.SetBool("isWalking", false);
        }
        
        agent.speed = 5;

        if (Input.GetMouseButtonDown(1))
        {

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // make player facing the mouse click position
            if (Physics.Raycast(ray, out hit))
            {
                transform.LookAt(hit.point);
            }


            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
                //set speed
            }
        }
    }

}
