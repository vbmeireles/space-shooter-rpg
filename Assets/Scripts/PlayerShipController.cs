using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShipController : MonoBehaviour
{
    PlayerInput playerInput;

    [SerializeField] float movementSpeed = 5f;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        transform.Translate(playerInput.actions["Move"].ReadValue<Vector2>() * movementSpeed * Time.fixedDeltaTime);
    }

    public void ShowDebug()
    {
        Debug.Log(playerInput.actions["Move"].ReadValue<Vector2>().ToString());
    }
}
