using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float maxSpeed = 2, acceleration = 50, deacceleration = 100;
    [SerializeField] private float currentSpeed = 0;

    private Vector2 oldMovementInput;
    public Vector2 MovementInput { get; set; }

    // Variables dash
    private bool isDashing = false;
    private float dashDuration = 0.2f;
    private float dashTimer = 0f;
    private Vector2 dashVelocity;
    [SerializeField] private float dashSpeed = 5f; // ajuste la vitesse du dash

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
        
    private void FixedUpdate()
    {

        if (isDashing)
        {
            rb.velocity = dashVelocity;
            dashTimer -= Time.fixedDeltaTime;
            if (dashTimer <= 0f)
            {
                isDashing = false;
            }
        }
        else
        {
            if (MovementInput.magnitude > 0 && currentSpeed >= 0)
            {
                oldMovementInput = MovementInput;
                currentSpeed += acceleration * maxSpeed * Time.fixedDeltaTime;
            }
            else
            {
                currentSpeed -= deacceleration * maxSpeed * Time.fixedDeltaTime;
            }
            currentSpeed = Mathf.Clamp(currentSpeed, 0, maxSpeed);
            rb.velocity = oldMovementInput * currentSpeed;
        }
    }

    public void StartDash(Vector2 direction)
    {
        if (direction == Vector2.zero)
            direction = Vector2.right;

        isDashing = true;
        dashTimer = dashDuration;
        dashVelocity = direction.normalized * maxSpeed * dashSpeed;
    }
}
