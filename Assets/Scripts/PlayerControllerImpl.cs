using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerControllerImpl : AbstractPlayerController
{
    private Camera m_playerCamera;
    private Rigidbody m_rigidBody;

    protected new void Awake()
    {
        base.Awake();

        m_playerCamera = GetComponent<Camera>();
        m_rigidBody = GetComponent<Rigidbody>();
    }

    protected override void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("OnJump: " + context.ToString());
    }

    protected override void OnLook(InputAction.CallbackContext context)
    {
        Debug.Log("OnLook: " + context.ToString());
    }

    protected override void OnReload(InputAction.CallbackContext context)
    {
        Debug.Log("OnReload: " + context.ToString());
    }

    protected override void OnRun(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("OnRun: context.performed");
        }
        else if (context.canceled)
        {
            Debug.Log("OnRun: context.canceled");
        }
    }

    protected override void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("OnInteract: context.performed");
        }
        else if (context.canceled)
        {
            Debug.Log("OnInteract: context.canceled");
        }
    }

    protected override void OnCrouch(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("OnCrouch: context.performed");
        }
        else if (context.canceled)
        {
            Debug.Log("OnCrouch: context.canceled");
        }
    }

    protected override void OnMove(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("OnMove: context.performed");
        }
        else if (context.canceled)
        {
            Debug.Log("OnMove: context.canceled");
        }
    }

    void Start()
    {
    }

    void Update()
    {
    }
}
