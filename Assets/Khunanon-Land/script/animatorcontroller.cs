using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorcontroller : MonoBehaviour
{
    CharacterController characterController;
    public float speed;
    private Vector3 moveDirection = Vector3.zero;
    Rigidbody rigidbody;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.isGrounded)
        {
            animator.SetBool("run", false);

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
            {
                animator.SetBool("run", true);
            }


            if (Input.GetAxis("Vertical") < 0)
            {
                this.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else
            {
                this.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            if (Input.GetAxis("Horizontal") < 0)
            {
                this.transform.rotation = Quaternion.Euler(0, -90, 0);
            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                this.transform.rotation = Quaternion.Euler(0, 90, 0);
            }


        }
        characterController.Move(moveDirection * Time.deltaTime);


        //input danace emotion

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animator.SetBool("dance1", true);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            animator.SetBool("dance1", false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animator.SetBool("dance2", true);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            animator.SetBool("dance2", false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            animator.SetBool("dance3", true);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            animator.SetBool("dance3", false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            animator.SetBool("dance4", true);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            animator.SetBool("dance4", false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            animator.SetBool("dance5", true);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            animator.SetBool("dance5", false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            animator.SetBool("dance6", true);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            animator.SetBool("dance6", false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            animator.SetBool("dance7", true);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha7))
        {
            animator.SetBool("dance7", false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            animator.SetBool("dance8", true);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha8))
        {
            animator.SetBool("dance8", false);
        }
    }

   
}
