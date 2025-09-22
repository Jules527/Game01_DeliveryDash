using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    private Rigidbody2D rb;

    public float steerSpeed = 100f;
    public float moveSpeed = 50f;

    void Start() =>
        rb = GetComponent<Rigidbody2D>();

    void FixedUpdate()
    {
        float verticalInput = 0;
        if (Keyboard.current.wKey.isPressed) verticalInput = 1;
        if (Keyboard.current.sKey.isPressed) verticalInput = -1;

        float horizontalInput = 0;
        if (Keyboard.current.aKey.isPressed) horizontalInput = -1;
        if (Keyboard.current.dKey.isPressed) horizontalInput = 1;

        // Move forward/back
        Vector2 movement = transform.up * verticalInput * moveSpeed;
        rb.AddForce(movement);

        // Rotate (steer)
        float rotation = -horizontalInput * steerSpeed * Time.fixedDeltaTime;
        rb.MoveRotation(rb.rotation + rotation);
    }
}


