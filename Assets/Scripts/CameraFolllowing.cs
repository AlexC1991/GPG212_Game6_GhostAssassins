using UnityEngine;

public class CameraFolllowing : MonoBehaviour
{
    [SerializeField] private Transform target; // The target the camera should follow (usually your player)
    [SerializeField] private float smoothSpeed = 0.125f; // Smoothing speed for camera movement
    [SerializeField] private float distanceFromPlayer = 5.0f;

    void FixedUpdate()
    {
        Vector3 directionFromPlayer = target.forward;  // Changed this to match player's forward direction
        Vector3 desiredPosition = target.position + directionFromPlayer * distanceFromPlayer;  // Removed the offset
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    
        transform.LookAt(target);
    }
}
