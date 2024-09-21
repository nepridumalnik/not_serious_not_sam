using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerControllerImpl : BasePlayerController
{
    protected new void Awake()
    {
        base.Awake();
    }

    protected override void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("OnJump: " + context.ToString());
    }

    protected override void OnCrouch(InputAction.CallbackContext context)
    {
        Debug.Log("OnCrouch: " + context.ToString());
    }

    protected override void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log("OnMove: " + context.ToString());
    }

    void Start()
    {
    }

    void Update()
    {
    }
}
