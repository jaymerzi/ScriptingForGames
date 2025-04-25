using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(AudioSource))]
public class SimpleCharacterController : MonoBehaviour
{
    
    public SimpleFloatData health;
    public float moveSpeed = 5f;
    public float jumpForce = 3f;
    public float gravity = -9.81f;

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

    // Update is called once per frame
    private void Update()
    {
        if (health.value > 0f)
        {
            MoveCharacter();
            ApplyGravity();
            KeepCharacterOnXAxis();
        }
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
        if (Input.GetButtonDown("Jump"))
        {
            audioSource.Play();
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }
    }

    private void ApplyGravity()
    {
        if (!controller.isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
        }
        else
        {
            velocity.y = 0f; // Reset velocity when grounded
        }

        // Apply the velocity to the controller
        controller.Move(velocity * Time.deltaTime);
    }

    private void KeepCharacterOnXAxis()
    {
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
}
