using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target; // The player to follow
    [SerializeField] private float smoothSpeed = 5f; // Camera smoothness
    [SerializeField] private Vector3 offset = new Vector3(0, 0, -10); // Camera offset

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate desired position
            Vector3 desiredPosition = target.position + offset;

            // Smoothly move camera
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }
    }
}