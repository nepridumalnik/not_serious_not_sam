using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerImpl : AbstractPlayerController
{
    public float mouseSensitivity = 1f;
    public float clampLookMax = 80f;
    public float clampLookMin = -80f;

    public Camera playerCamera = null;
    private Rigidbody m_rigidBody = null;
    private GunSystem m_gun = null;

    private CrouchController m_crouchController = null;
    private MoveController m_moveController = null;

    /// <summary>
    /// Единственная цель этой переменной - сделать чтобы множитель mouseSensitivity был равен единице в среднем
    /// </summary>
    private readonly float m_sensitivityMultiplierConstant = 30f;

    protected new void Awake()
    {
        base.Awake();
    }

    protected override void OnJump(InputAction.CallbackContext context)
    {
        // Проверяем, что прыжок был инициирован
        if (context.performed)
        {
            m_moveController.OnJump();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        m_moveController.CheckCollision();
    }

    protected override void OnFire(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            m_gun.PullTrigger();
        }
        else if (context.canceled)
        {
            m_gun.ReleaseTrigger();
        }
    }

    protected override void OnSecondaryFire(InputAction.CallbackContext context)
    {
        // Debug.Log("OnSecondaryFire: " + context.ToString());
    }

    protected override void OnAlternateFire(InputAction.CallbackContext context)
    {
        // Debug.Log("OnAlternateFire: " + context.ToString());
    }

    protected override void OnScroll(InputAction.CallbackContext context)
    {
        // Debug.Log("OnScroll: " + context.ToString());
    }

    protected override void OnLook(InputAction.CallbackContext context)
    {
        // 2D вектор для представления пространства перемещения мыши
        Vector2 lookInput = context.ReadValue<Vector2>();

        float sensitivityMultiplier = mouseSensitivity * Time.deltaTime * m_sensitivityMultiplierConstant;

        float horizontalRotation = lookInput.x * sensitivityMultiplier;
        float verticalRotation = -lookInput.y * sensitivityMultiplier;

        // Получаем текущий угол поворота камеры
        Vector3 currentRotation = playerCamera.transform.localEulerAngles;

        // Преобразуем угол в диапазон [-180, 180] для корректной работы с ограничениями
        if (currentRotation.x > 180)
        {
            currentRotation.x -= 360;
        }

        // Добавляем горизонтальный поворот (без ограничений)
        currentRotation.y += horizontalRotation;

        // Добавляем вертикальный поворот с ограничением по углам
        currentRotation.x = Mathf.Clamp(currentRotation.x + verticalRotation, clampLookMin, clampLookMax);

        // Применяем новый угол поворота
        playerCamera.transform.localRotation = Quaternion.Euler(currentRotation.x, currentRotation.y, currentRotation.z);
    }

    protected override void OnReload(InputAction.CallbackContext context)
    {
        Debug.Log("OnReload: " + context.ToString());
        if (context.performed)
        {
            m_gun.Reload();
        }
    }

    protected override void OnRun(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            m_moveController.Run();
        }
        else if (context.canceled)
        {
            m_moveController.UnRun();
        }
    }

    protected override void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            // Debug.Log("OnInteract: context.performed");
        }
        else if (context.canceled)
        {
            // Debug.Log("OnInteract: context.canceled");
        }
    }

    protected override void OnCrouch(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            m_crouchController.SitDown();
        }
        else if (context.canceled)
        {
            m_crouchController.AntiSitDown();
        }
    }

    protected override void OnMove(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

            Vector2 move = context.ReadValue<Vector2>();
            m_moveController.OnMove(move);
        }
        else if (context.canceled)
        {
            m_moveController.OnStop();
        }
    }

    void Start()
    {
        m_gun = gameObject.AddComponent<GunSystem>();
        m_gun.fpsCamera = playerCamera;

        m_rigidBody = GetComponent<Rigidbody>();
        playerCamera.transform.localRotation = m_rigidBody.transform.localRotation;

        m_crouchController = CrouchController.AddToGameObject(gameObject, GetComponent<CapsuleCollider>());
        m_moveController = MoveController.AddToGameObject(gameObject, m_crouchController, playerCamera, m_rigidBody);
    }

    void FixedUpdate()
    {
        m_moveController.Move();
    }

    void Update()
    {
    }
}
