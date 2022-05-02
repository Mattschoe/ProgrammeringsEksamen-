using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject Inspection;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private float speed = 5.0f;
    [SerializeField]
    private float rotationSpeed;

    private void Update()
    {
        if (Inspection.active)
        {
            return;
        }
        else 
        {
            //Input til movement. Banen er bygget forkert på koordinatsystemet, så vi bytter om på Vertical og Horizontal
            float horizontalInput = Input.GetAxis("Vertical");
            float verticalInput = Input.GetAxis("Horizontal");

            //Sætter horizontalInput i minus "w" er frem og "s" er tilbage
            Vector3 movementDirection = new Vector3(-horizontalInput, 0, verticalInput);
            movementDirection.Normalize();

            transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

            //Drejer spilleren rundt
            if (movementDirection != Vector3.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime); 
            }

            //Til at spille "PlayerMove" animationen under bevægelse
            float moveInput = horizontalInput + verticalInput;
            if (moveInput == 0f)
            {
                animator.SetBool("isMoving", false);
            }
            else
            {
                animator.SetBool("isMoving", true);
            }
        }
    }
}
