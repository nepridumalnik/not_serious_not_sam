using System;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    /// <summary>
    /// Единственная цель этой переменной - сделать чтобы множитель m_mouseSensitivity был равен единице в среднем
    /// </summary>
    private readonly float m_sensitivityMultiplierConstant = 30f;
    private readonly float m_mouseSensitivity = 1f;
    public readonly float m_clampLookMax = 80f;
    public readonly float m_clampLookMin = -80f;

    private WeakReference<Camera> m_playerCamera = null;

    public Camera Camera
    {
        set => m_playerCamera = new WeakReference<Camera>(value);
    }

    public static MouseController AddToGameObject(GameObject gameObject, Camera camera)
    {
        var mouseController = gameObject.AddComponent<MouseController>();
        mouseController.Camera = camera;

        return mouseController;
    }

    public void OnLook(Vector2 look)
    {
        if (m_playerCamera.TryGetTarget(out var camera))
        {
            float sensitivityMultiplier = m_mouseSensitivity * Time.deltaTime * m_sensitivityMultiplierConstant;

            float horizontalRotation = look.x * sensitivityMultiplier;
            float verticalRotation = -look.y * sensitivityMultiplier;

            // Получаем текущий угол поворота камеры
            Vector3 currentRotation = camera.transform.localEulerAngles;

            // Преобразуем угол в диапазон [-180, 180] для корректной работы с ограничениями
            if (currentRotation.x > 180)
            {
                currentRotation.x -= 360;
            }

            // Добавляем горизонтальный поворот (без ограничений)
            currentRotation.y += horizontalRotation;

            // Добавляем вертикальный поворот с ограничением по углам
            currentRotation.x = Mathf.Clamp(currentRotation.x + verticalRotation, m_clampLookMin, m_clampLookMax);

            // Применяем новый угол поворота
            camera.transform.localRotation = Quaternion.Euler(currentRotation.x, currentRotation.y, currentRotation.z);
        }
    }
}
