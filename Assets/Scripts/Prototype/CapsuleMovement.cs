using UnityEngine;

/// <summary>
/// Camera-relative, ground-based movement for the prototype capsule.
/// </summary>
[RequireComponent(typeof(CharacterController))]
public sealed class CapsuleMovement : MonoBehaviour
{
    [SerializeField] private PrototypeInputReader input;
    [SerializeField] private Transform movementCamera;
    [SerializeField, Min(0f)] private float moveSpeed = 5f;
    [SerializeField, Min(0f)] private float turnSpeed = 720f;
    [SerializeField] private float gravity = -25f;

    private CharacterController _controller;
    private float _verticalSpeed;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();

        if (input == null)
            input = GetComponent<PrototypeInputReader>();
    }

    private void Update()
    {
        if (input == null || movementCamera == null)
            return;

        Vector2 inputDirection = Vector2.ClampMagnitude(input.MoveInput, 1f);
        Vector3 cameraForward = Vector3.ProjectOnPlane(movementCamera.forward, Vector3.up).normalized;
        Vector3 cameraRight = Vector3.ProjectOnPlane(movementCamera.right, Vector3.up).normalized;
        Vector3 moveDirection = cameraForward * inputDirection.y + cameraRight * inputDirection.x;

        if (moveDirection.sqrMagnitude > 1f)
            moveDirection.Normalize();

        if (_controller.isGrounded && _verticalSpeed < 0f)
            _verticalSpeed = -2f;
        else
            _verticalSpeed += gravity * Time.deltaTime;

        Vector3 velocity = moveDirection * moveSpeed + Vector3.up * _verticalSpeed;
        _controller.Move(velocity * Time.deltaTime);

        if (moveDirection.sqrMagnitude > 0.001f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
        }
    }
}
