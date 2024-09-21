using UnityEngine;
using UnityEngine.InputSystem;


public abstract class AbstractPlayerController : MonoBehaviour
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
        m_controller.PlayerInput.Crouch.canceled += OnCrouch;
        m_controller.PlayerInput.Move.performed += OnMove;
        m_controller.PlayerInput.Move.canceled += OnMove;
        m_controller.PlayerInput.Reload.performed += OnReload;
        m_controller.PlayerInput.Run.performed += OnRun;
        m_controller.PlayerInput.Run.canceled += OnRun;
        m_controller.PlayerInput.Look.performed += OnLook;
        m_controller.PlayerInput.Look.canceled += OnLook;
        m_controller.PlayerInput.Interact.performed += OnInteract;
        m_controller.PlayerInput.Interact.canceled += OnInteract;
        m_controller.PlayerInput.Interact.performed += OnInteract;
        m_controller.PlayerInput.Interact.canceled += OnInteract;
        m_controller.PlayerInput.Fire.performed += OnFire;
        m_controller.PlayerInput.Fire.performed += OnFire;
        m_controller.PlayerInput.SecondaryFire.canceled += OnSecondaryFire;
        m_controller.PlayerInput.SecondaryFire.canceled += OnSecondaryFire;
        m_controller.PlayerInput.AlternateFire.performed += OnAlternateFire;
        m_controller.PlayerInput.AlternateFire.canceled += OnAlternateFire;
        m_controller.PlayerInput.Scroll.performed += OnScroll;
        m_controller.PlayerInput.Scroll.canceled += OnScroll;

        m_controller.Enable();
    }

    private void OnDisable()
    {
        m_controller.PlayerInput.Jump.performed -= OnJump;
        m_controller.PlayerInput.Crouch.performed -= OnCrouch;
        m_controller.PlayerInput.Crouch.canceled -= OnCrouch;
        m_controller.PlayerInput.Move.performed -= OnMove;
        m_controller.PlayerInput.Move.canceled -= OnMove;
        m_controller.PlayerInput.Reload.performed -= OnReload;
        m_controller.PlayerInput.Run.performed -= OnRun;
        m_controller.PlayerInput.Run.canceled -= OnRun;
        m_controller.PlayerInput.Look.performed -= OnLook;
        m_controller.PlayerInput.Look.canceled -= OnLook;
        m_controller.PlayerInput.Interact.performed -= OnInteract;
        m_controller.PlayerInput.Interact.canceled -= OnInteract;
        m_controller.PlayerInput.Fire.performed -= OnFire;
        m_controller.PlayerInput.Fire.performed -= OnFire;
        m_controller.PlayerInput.SecondaryFire.canceled -= OnSecondaryFire;
        m_controller.PlayerInput.SecondaryFire.canceled -= OnSecondaryFire;
        m_controller.PlayerInput.AlternateFire.performed -= OnAlternateFire;
        m_controller.PlayerInput.AlternateFire.canceled -= OnAlternateFire;
        m_controller.PlayerInput.Scroll.performed -= OnScroll;
        m_controller.PlayerInput.Scroll.canceled -= OnScroll;

        m_controller.Disable();
    }

    abstract protected void OnJump(InputAction.CallbackContext context);
    abstract protected void OnCrouch(InputAction.CallbackContext context);
    abstract protected void OnMove(InputAction.CallbackContext context);
    abstract protected void OnLook(InputAction.CallbackContext context);
    abstract protected void OnReload(InputAction.CallbackContext context);
    abstract protected void OnRun(InputAction.CallbackContext context);
    abstract protected void OnInteract(InputAction.CallbackContext context);
    abstract protected void OnFire(InputAction.CallbackContext context);
    abstract protected void OnSecondaryFire(InputAction.CallbackContext context);
    abstract protected void OnAlternateFire(InputAction.CallbackContext context);
    abstract protected void OnScroll(InputAction.CallbackContext context);
}
