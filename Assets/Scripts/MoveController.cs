using System;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    private bool m_runPressed = false;
    private bool m_isJumping = false;
    public readonly float m_jumpForce = 5f;
    private readonly float m_moveSpeed = 10f;
    private readonly float m_runMultiplier = 1.5f;
    public float m_decelerationTime = 0.2f;
    private Vector2 m_vecSpeed = Vector2.zero;

    private WeakReference<Camera> m_playerCamera = null;
    private WeakReference<Rigidbody> m_rigidBody = null;
    private WeakReference<CrouchController> m_crouchController = null;

    /// <summary>
    /// Создать экземпляр правильным способом и сразу добавить на GameObject
    /// </summary>
    /// <param name="gameObject">Родительский GameObject</param>
    /// <param name="crouchController">Родительский CrouchController</param>
    /// <param name="camera">Родительский Camera</param>
    /// <param name="rigidbody">Родительский Rigidbody</param>
    /// <returns></returns>
    public static MoveController AddToGameObject(GameObject gameObject, CrouchController crouchController, Camera camera, Rigidbody rigidbody)
    {
        var moveController = gameObject.AddComponent<MoveController>();
        moveController.CrouchController = crouchController;
        moveController.Camera = camera;
        moveController.RigidBody = rigidbody;

        return moveController;
    }

    public Rigidbody RigidBody
    {
        set => m_rigidBody = new WeakReference<Rigidbody>(value);
    }

    public Camera Camera
    {
        set => m_playerCamera = new WeakReference<Camera>(value);
    }

    public CrouchController CrouchController
    {
        set => m_crouchController = new WeakReference<CrouchController>(value);
    }

    void Start()
    {
    }

    public void Run()
    {
        m_runPressed = true;
    }

    public void UnRun()
    {
        m_runPressed = false;
    }

    private bool IsRunning()
    {
        // Критерий успеха - если вертикальная составляющая равна нулю и больше или равна горизонтальной
        if (!m_runPressed)
        {
            return false;
        }

        if (!m_crouchController.TryGetTarget(out var target) || target.IsCrouching())
        {
            return false;
        }

        return m_vecSpeed.y > 0 && m_vecSpeed.y >= m_vecSpeed.x;
    }

    public void Move()
    {
        if (m_isJumping)
        {
            return;
        }

        Vector3 forward;
        Vector3 right;

        if (m_playerCamera.TryGetTarget(out var camera) && m_rigidBody.TryGetTarget(out var rigidBody))
        {
            forward = camera.transform.forward;
            right = camera.transform.right;

            forward.y = 0;
            right.y = 0;

            float speed = IsRunning() ? m_moveSpeed * m_runMultiplier : m_moveSpeed;

            forward.Normalize();
            right.Normalize();

            // Если скорость ввода обнулилась, то начинаем тормозить
            if (m_vecSpeed == Vector2.zero)
            {
                rigidBody.linearVelocity = Vector3.Lerp(rigidBody.linearVelocity, Vector3.zero, Time.fixedDeltaTime / m_decelerationTime);
            }
            else
            {
                // Иначе двигаемся с нормальной скоростью
                Vector3 targetVelocity = (forward * m_vecSpeed.y + right * m_vecSpeed.x) * speed;
                rigidBody.linearVelocity = Vector3.Lerp(rigidBody.linearVelocity, targetVelocity, Time.fixedDeltaTime / m_decelerationTime); ;
            }
        }
    }

    public void OnMove(Vector2 move)
    {
        m_vecSpeed.x = move.x;
        m_vecSpeed.y = move.y;
    }

    public void OnStop()
    {
        m_vecSpeed = Vector2.zero;
    }

    public void CheckCollision()
    {
        m_isJumping = !IsGrounded();
    }

    public void OnJump()
    {
        // Проверяем, что прыжок был инициирован
        if (IsGrounded() && m_rigidBody.TryGetTarget(out var target))
        {
            target.linearVelocity = new Vector3(target.linearVelocity.x, target.transform.up.normalized.y * m_jumpForce, target.linearVelocity.z);
            m_isJumping = true;
        }
    }

    private bool IsGrounded()
    {
        if (m_rigidBody.TryGetTarget(out var target))
        {
            return Physics.Raycast(target.transform.position, -target.transform.up, 1.01f);
        }

        return false;
    }
}
