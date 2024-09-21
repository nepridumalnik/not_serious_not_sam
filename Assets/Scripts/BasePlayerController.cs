using UnityEngine;
using UnityEngine.InputSystem;


public abstract class BasePlayerController : MonoBehaviour
{
    private PlayerInputController m_controller;

    protected void Awake()
    {
        m_controller = new PlayerInputController();
    }

    private void OnEnable()
    {
        m_controller.PlayerInput.Jump.performed += OnJump;
        m_controller.PlayerInput.Crouch.performed += OnCrouch;
        m_controller.PlayerInput.Move.performed += OnMove;

        m_controller.Enable();
    }

    private void OnDisable()
    {
        m_controller.PlayerInput.Jump.performed -= OnJump;
        m_controller.PlayerInput.Crouch.performed -= OnCrouch;
        m_controller.PlayerInput.Move.performed -= OnMove;

        m_controller.Disable();
    }

    abstract protected void OnJump(InputAction.CallbackContext context);
    abstract protected void OnCrouch(InputAction.CallbackContext context);
    abstract protected void OnMove(InputAction.CallbackContext context);
}
