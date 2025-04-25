using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    
    FirstPersonCamera firstpersoncamera;
    Movement characterMovement;
    PlayerInteraction playerInteraction;
    
    // Start is called before the first frame update
    void Start()
    {
        firstpersoncamera = GetComponent<FirstPersonCamera>();
        characterMovement = GetComponent<Movement>();
        playerInteraction = GetComponent<PlayerInteraction>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleCameraInput();
        HandleMoveInput();
        HandleInteractInput();
    }


    void HandleCameraInput()
{
    float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime;
    float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime;

    firstpersoncamera.AddXAxisInput(-mouseY);
    firstpersoncamera.AddYAxisInput(mouseX);
}

    void HandleMoveInput()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float rightInput = Input.GetAxis("Horizontal");

        characterMovement.Move(forwardInput, rightInput);
    }

    void HandleInteractInput()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            playerInteraction.TryInteract();
        }
    }
}