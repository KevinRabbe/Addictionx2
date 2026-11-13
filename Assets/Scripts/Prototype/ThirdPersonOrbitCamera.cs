using UnityEngine;

/// <summary>
/// Mouse-controlled third-person follow and orbit camera for the movement graybox.
/// </summary>
[RequireComponent(typeof(Camera))]
public sealed class ThirdPersonOrbitCamera : MonoBehaviour
{
    [SerializeField] private PrototypeInputReader input;
    [SerializeField] private Transform target;
    [SerializeField, Min(0f)] private float distance = 6f;
    [SerializeField, Min(0f)] private float sensitivity = 0.12f;
    [SerializeField] private float minPitch = -25f;
    [SerializeField] private float maxPitch = 65f;
    [SerializeField, Min(0f)] private float followSharpness = 15f;

    private float _yaw;
    private float _pitch = 15f;

    private void LateUpdate()
    {
        if (input == null || target == null)
            return;

        Vector2 look = input.LookInput;
        _yaw += look.x * sensitivity;
        _pitch = Mathf.Clamp(_pitch - look.y * sensitivity, minPitch, maxPitch);

        Quaternion orbitRotation = Quaternion.Euler(_pitch, _yaw, 0f);
        Vector3 desiredPosition = target.position - orbitRotation * Vector3.forward * distance;
        float followBlend = 1f - Mathf.Exp(-followSharpness * Time.deltaTime);

        transform.position = Vector3.Lerp(transform.position, desiredPosition, followBlend);
        transform.rotation = Quaternion.LookRotation(target.position - transform.position, Vector3.up);
    }
}
