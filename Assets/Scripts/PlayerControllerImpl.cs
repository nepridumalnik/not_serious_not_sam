using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerImpl : AbstractPlayerController
{
    public float moveSpeed = 10f;
    public float runMultiplier = 1.5f;
    public float mouseSensitivity = 1f;
    public float clampLookMax = 80f;
    public float clampLookMin = -80f;

    public Camera playerCamera;
    private Rigidbody m_rigidBody;

    private Vector2 m_vecSpeed;
    private bool m_isRun = false;

    protected new void Awake()
    {
        base.Awake();

        m_vecSpeed = Vector2.zero;
        m_rigidBody = GetComponent<Rigidbody>();
        playerCamera.transform.localRotation = m_rigidBody.transform.localRotation;
    }

    protected override void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("OnJump: " + context.ToString());
    }

    protected override void OnFire(InputAction.CallbackContext context)
    {
        Debug.Log("OnFire: " + context.ToString());
    }

    protected override void OnSecondaryFire(InputAction.CallbackContext context)
    {
        Debug.Log("OnSecondaryFire: " + context.ToString());
    }

    protected override void OnAlternateFire(InputAction.CallbackContext context)
    {
        Debug.Log("OnAlternateFire: " + context.ToString());
    }

    protected override void OnScroll(InputAction.CallbackContext context)
    {
        Debug.Log("OnScroll: " + context.ToString());
    }

    protected override void OnLook(InputAction.CallbackContext context)
    {
        // 2D вектор для представления пространства перемещения мыши
        Vector2 lookInput = context.ReadValue<Vector2>();

        float horizontalRotation = lookInput.x * mouseSensitivity;
        float verticalRotation = -lookInput.y * mouseSensitivity;

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
    }

    protected override void OnRun(InputAction.CallbackContext context)
    {
        m_isRun = context.performed;

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

            Vector2 move = context.ReadValue<Vector2>();
            m_vecSpeed.x = move.x;
            m_vecSpeed.y = move.y;
        }
        else if (context.canceled)
        {
            Debug.Log("OnMove: context.canceled");
            m_vecSpeed = Vector2.zero;
        }
    }

    void Start()
    {
    }

    void FixedUpdate()
    {
        Move();
    }

    void Update()
    {
    }

    private void Move()
    {
        // Получаем направление вперед и вправо камеры
        Vector3 forward = playerCamera.transform.forward;
        Vector3 right = playerCamera.transform.right;

        // Убираем вертикальную компоненту, чтобы движение было только по горизонтали
        forward.y = 0;
        right.y = 0;

        float speed = !m_isRun ? moveSpeed : moveSpeed * runMultiplier;

        // Нормализуем векторы
        forward.Normalize();
        right.Normalize();

        // Применяем скорость на основе ввода
        Vector3 linearVelocity = (forward * m_vecSpeed.y + right * m_vecSpeed.x) * speed; // Умножаем на speed для управления скоростью

        // Устанавливаем скорость Rigidbody
        m_rigidBody.linearVelocity = linearVelocity;
    }
}
