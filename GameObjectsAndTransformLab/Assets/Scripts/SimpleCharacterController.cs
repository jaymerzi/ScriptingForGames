using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(AudioSource))]
public class SimpleCharacterController : MonoBehaviour
{
    
    public SimpleFloatData health;
    public string groundTag = "Ground";
    public float moveSpeed = 5f;
    public float jumpForce = 3f;
    public float gravity = -9.81f;
    public static bool grounded = false;
    public float groundedCheckDistance;
    private float bufferCheckDistance = 0.1f;
    private CharacterController controller;
    private Transform thisTransform;
    private Vector3 velocity;
    public UnityEvent triggerEvent;
    private AudioSource audioSource;

    // Start is called before the first frame update
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
        audioSource = GetComponent<AudioSource>();
    }

    /*private void OnCollisionEnter(Collision other)
            {
                if (other.gameObject.tag == "Ground")
                {
                    grounded = true;
                }
            }

    private void OnCollisionExit(Collision other)
            {
                if (other.gameObject.tag == "Ground")
                {
                    grounded = false;
                }
            }*/

    // Update is called once per frame
    private void Update()
    {
        
        if (health.value > 0f)
        {   
            groundedCheckDistance = (controller.height / 2) + bufferCheckDistance;
            RaycastHit hit;
            if (Physics.Raycast(transform.position, -thisTransform.up, out hit, groundedCheckDistance))
            {
                if (hit.collider !=null && hit.collider.tag == groundTag)
                grounded = true;
            }
            else
            {
                grounded = false;
            }
            //THIS GROUND CHECK WORKS OMFG
            MoveCharacter();

            if (!grounded)
            {
                velocity.y += gravity * Time.deltaTime;
            }
            else
            {
                velocity.y = 0f;
            }

            controller.Move(velocity * Time.deltaTime);
            KeepCharacterOnXAxis();
        }
    }

        IEnumerator test()
        {
            yield return new WaitForSeconds(0f);
            velocity.y = 0f;
        }

    private void MoveCharacter()
    {
        var moveInput = Input.GetAxis("Horizontal");
        var move = new Vector3(moveInput, 0f, 0f) * (moveSpeed * Time.deltaTime);
        controller.Move(move);
        
        //movementVector.x = Input.GetAxis("Horizontal");
        //movementVector *= (moveSpeed * Time.deltaTime);
        //controller.Move(movementVector);

        //Jumping
        if (Input.GetButtonDown("Jump") && grounded)
        {
            grounded = false;
            audioSource.Play();
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }
    }

    /*private void ApplyGravity()
    {
            velocity.y = 0f;
        
            //velocity.y += gravity * Time.deltaTime;

        //if (grounded == false)
        //{
            //velocity.y += gravity * Time.deltaTime;
        //}
        //else
        //{
            //velocity.y = 0f; // Reset velocity when grounded
        //}

        // Apply the velocity to the controller
        controller.Move(velocity * Time.deltaTime);
    }*/

    private void KeepCharacterOnXAxis()
    {
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
}
