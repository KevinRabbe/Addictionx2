using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Reads the existing Player/Move and Player/Look actions for the movement graybox.
/// </summary>
public sealed class PrototypeInputReader : MonoBehaviour
{
    [SerializeField] private InputActionAsset inputActions;
    [SerializeField] private bool lockCursorOnPlay = true;

    private InputActionMap _playerMap;
    private InputAction _moveAction;
    private InputAction _lookAction;
    private InputAction _cancelAction;
    private bool _shouldLockCursor;

    public Vector2 MoveInput => _moveAction != null ? _moveAction.ReadValue<Vector2>() : Vector2.zero;

    public Vector2 LookInput => _shouldLockCursor && Cursor.lockState == CursorLockMode.Locked && _lookAction != null
        ? _lookAction.ReadValue<Vector2>()
        : Vector2.zero;

    private void OnEnable()
    {
        if (inputActions == null)
        {
            Debug.LogError("PrototypeInputReader needs the existing InputSystem_Actions asset assigned.", this);
            enabled = false;
            return;
        }

        _playerMap = inputActions.FindActionMap("Player", true);
        _moveAction = _playerMap.FindAction("Move", true);
        _lookAction = _playerMap.FindAction("Look", true);
        _cancelAction = inputActions.FindAction("UI/Cancel", false);

        _playerMap.Enable();
        _cancelAction?.Enable();

        _shouldLockCursor = lockCursorOnPlay;
        ApplyCursorState();
    }

    private void Update()
    {
        if (_cancelAction != null && _cancelAction.WasPressedThisFrame())
        {
            _shouldLockCursor = false;
            ApplyCursorState();
            return;
        }

        if (!_shouldLockCursor && Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            _shouldLockCursor = true;
            ApplyCursorState();
        }
    }

    private void OnApplicationFocus(bool hasFocus)
    {
        if (!hasFocus)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (_shouldLockCursor)
        {
            ApplyCursorState();
        }
    }

    private void OnDisable()
    {
        _playerMap?.Disable();
        _cancelAction?.Disable();
        _shouldLockCursor = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void ApplyCursorState()
    {
        Cursor.lockState = _shouldLockCursor ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !_shouldLockCursor;
    }
}
