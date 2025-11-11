using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f; // Movement speed

    void Update()
    {
        // Get input from arrow keys.
        float horizontalInput = Input.GetAxis("Horizontal"); // Left and Right arrows.
        float verticalInput = Input.GetAxis("Vertical"); // Up and Down arrows.

        // Create movement vector
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0);

        // Move the player
        transform.position += movement * moveSpeed * Time.deltaTime;
    }
}