using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed = 3f;
    PlayerControls controls;
    private Vector2 moveAxis;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        controls.Player.Move.performed += HandleMove; //Observer pattern
        controls.Player.Move.Enable();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveAxis * speed * Time.deltaTime); 
    }

    public void HandleMove(InputAction.CallbackContext context)
    {
        moveAxis = context.ReadValue<Vector2>();
        Debug.Log($"Move axis {moveAxis}");
    }
}
