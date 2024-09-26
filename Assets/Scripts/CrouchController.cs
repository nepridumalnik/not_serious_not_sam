using System;
using System.Collections;
using UnityEngine;

public class CrouchController : MonoBehaviour
{
    private bool m_isCrouching = false;
    private readonly float m_crouchMax = 2f;
    private readonly float m_crouchMin = 1.35f;
    private readonly float m_crouchDuration = 0.3f;
    private new WeakReference<CapsuleCollider> collider = null;

    public CapsuleCollider Collider
    {
        set
        {
            collider = new WeakReference<CapsuleCollider>(value);
        }
    }

    public void SitDown()
    {
        m_isCrouching = true;
        if (collider.TryGetTarget(out CapsuleCollider target))
        {
            StartCoroutine(ChangeHeightCoroutine(target, target.height, m_crouchMin));
        }
    }

    public void AntiSitDown()
    {
        m_isCrouching = false;

        if (collider.TryGetTarget(out CapsuleCollider target))
        {
            StartCoroutine(ChangeHeightCoroutine(target, target.height, m_crouchMax));
        }
    }

    public bool IsCrouching() => m_isCrouching;

    private IEnumerator ChangeHeightCoroutine(CapsuleCollider collider, float currentHeight, float targetHeight)
    {
        bool currentCrouchState = m_isCrouching;
        float elapsedTime = 0f;

        while (elapsedTime < m_crouchDuration && m_isCrouching == currentCrouchState)
        {
            if (m_isCrouching != currentCrouchState)
            {
                break;
            }

            // Линейная интерполяция между начальной и целевой высотой
            collider.height = Mathf.Lerp(currentHeight, targetHeight, elapsedTime / m_crouchDuration);
            elapsedTime += Time.deltaTime;

            // Ждем следующий кадр
            yield return null;
        }


        if (m_isCrouching != currentCrouchState)
        {
            // Убедиться, что после завершения анимации высота точно соответствует целевой
            collider.height = targetHeight;
        }
    }
}
