using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerControllerImpl : AbstractPlayerController
{
    public float mouseSensitivity = 1f;
    public float clampLookMax = 80f;
    public float clampLookMin = -80f;

    public Camera playerCamera;
    private Rigidbody m_rigidBody;

    protected new void Awake()
    {
        base.Awake();

        m_rigidBody = GetComponent<Rigidbody>();
        playerCamera.transform.localRotation = m_rigidBody.transform.localRotation;
    }

    protected override void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("OnJump: " + context.ToString());
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
