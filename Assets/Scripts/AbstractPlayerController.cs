using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Абстрактный класс контроллера игрока
/// </summary>
public abstract class AbstractPlayerController : MonoBehaviour
{
    /// <summary>
    /// Контроллер ввода
    /// </summary>
    private PlayerInputController m_controller;

    /// <summary>
    /// Проснуться и настроить контроллер, обязательно к вызову для потомкой
    /// </summary>
    protected void Awake()
    {
        m_controller = new PlayerInputController();
    }

    /// <summary>
    /// Активация обработки ввода
    /// </summary>
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

    /// <summary>
    /// Деактивация обработки ввода
    /// </summary>
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

    /// <summary>
    /// Абстрактная функция прыжка
    /// </summary>
    /// <param name="context"></param>
    abstract protected void OnJump(InputAction.CallbackContext context);

    /// <summary>
    /// Абстрактная функция присяда
    /// </summary>
    /// <param name="context"></param>
    abstract protected void OnCrouch(InputAction.CallbackContext context);

    /// <summary>
    /// Абстрактная функция движения
    /// </summary>
    /// <param name="context"></param>
    abstract protected void OnMove(InputAction.CallbackContext context);

    /// <summary>
    /// Абстрактная функция изменения направления обзора
    /// </summary>
    /// <param name="context"></param>
    abstract protected void OnLook(InputAction.CallbackContext context);

    /// <summary>
    /// Абстрактная функция перезарядки оружия
    /// </summary>
    /// <param name="context"></param>
    abstract protected void OnReload(InputAction.CallbackContext context);

    /// <summary>
    /// Абстрактная функция нажатия кнопки бега
    /// </summary>
    /// <param name="context"></param>
    abstract protected void OnRun(InputAction.CallbackContext context);

    /// <summary>
    /// Абстрактная функция взаимодействия
    /// </summary>
    /// <param name="context"></param>
    abstract protected void OnInteract(InputAction.CallbackContext context);

    /// <summary>
    /// Абстрактная функция стрельбы (ЛКМ)
    /// </summary>
    /// <param name="context"></param>
    abstract protected void OnFire(InputAction.CallbackContext context);

    /// <summary>
    /// Абстрактная функция второй стрельбы (ПКМ)
    /// </summary>
    /// <param name="context"></param>
    abstract protected void OnSecondaryFire(InputAction.CallbackContext context);

    /// <summary>
    /// Абстрактная функция альтернативной стрельбы (СКМ)
    /// </summary>
    /// <param name="context"></param>
    abstract protected void OnAlternateFire(InputAction.CallbackContext context);

    /// <summary>
    /// Абстрактная функция прокрутки колеса мыши
    /// </summary>
    /// <param name="context"></param>
    abstract protected void OnScroll(InputAction.CallbackContext context);
}
