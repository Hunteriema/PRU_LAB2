using UnityEngine;

public class FollowCamera_NoRotation : MonoBehaviour
{
    [Header("Target to Follow")]
    [SerializeField] private Transform target;

    [Header("Follow Settings")]
    [SerializeField] private float smoothSpeed = 5f;
    [SerializeField] private Vector3 offset;

    void LateUpdate()
    {
        if (target == null) return;

        // Get target position but ignore rotation
        Vector3 desiredPosition = target.position + offset;

        // Smoothly interpolate to target position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Apply position update
        transform.position = smoothedPosition;

        // Keep camera rotation fixed (no rotation follow)
        transform.rotation = Quaternion.identity;
    }
}
