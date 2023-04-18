using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    InputAction moveUp = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveDown = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveLeft = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveRight = new InputAction(type: InputActionType.Button);

    // Update is called once per frame

    void OnEnable() {
        moveUp.Enable();
        moveDown.Enable();
        moveLeft.Enable();
        moveRight.Enable();    
    }

    void OnDisable() {
        moveUp.Disable();
        moveDown.Disable();
        moveLeft.Disable();
        moveRight.Disable();
    }
    void Update() {
        if(moveUp.WasPressedThisFrame()) {
            transform.position += new Vector3(0,1.5f,0);
        } else if (moveDown.WasPressedThisFrame()) {
            transform.position += new Vector3(0,-1.5f, 0);
        } else if (moveLeft.WasPressedThisFrame()) {
           transform.position += new Vector3(-1f, 0, 0);
        }
        else if(moveRight.WasPressedThisFrame()) {
            transform.position += new Vector3(1f, 0, 0);
        }
    }
}
