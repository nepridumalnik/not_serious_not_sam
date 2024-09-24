// https://www.youtube.com/watch?v=bqNW08Tac0Y

using UnityEngine;

public class GunSystem : MonoBehaviour
{
    // Public
    // Integers
    public int damage = 100;
    public uint magazineSize = 30;
    public uint bulletsPerShot = 1;

    // Floats
    public float shootingDelay = 0.1f;
    public float spread = 0.1f;
    public float range = 1000f;
    public float reloadTimeout = 1f;

    // Bools
    public bool holdAllowed = true;

    // Private
    // Unsigned integers
    private uint m_remainedBullets = 0;

    // Bools
    private bool m_shooting = false;
    private bool m_triggerHold = false;
    private bool m_triggerJustPressed = false;
    private bool m_readyToShot = true;
    private bool m_reloading = false;

    // References
    public Camera fpsCamera;
    public Transform attackPoint;
    public RaycastHit rcHit;

    // Methods
    private void Start()
    {
        m_remainedBullets = magazineSize;
    }

    public void PullTrigger()
    {
        m_triggerHold = true;
        m_triggerJustPressed = true;
    }

    public void ReleaseTrigger()
    {
        m_triggerHold = false;
    }

    public void Reload()
    {
        Debug.Log($"{nameof(Reload)}, m_reloading {m_reloading} bullets, m_remainedBullets: {m_remainedBullets}, magazineSize: {magazineSize}");
        if (m_reloading)
        {
            return;
        }
        if (!(m_remainedBullets < magazineSize))
        {
            return;
        }

        m_reloading = true;
        Invoke(nameof(ReloadFinished), reloadTimeout);
    }

    private void ReloadFinished()
    {
        m_remainedBullets = magazineSize;
        m_reloading = false;
        Debug.Log($"ReloadFinished, remains {m_remainedBullets} bullets");
    }

    private void Shoot()
    {
        try
        {
            // Применяем разброс
            float x = Random.Range(-spread, spread);
            float y = Random.Range(-spread, spread);
            Vector3 raycastDirection = fpsCamera.transform.forward + new Vector3(x, y, 0);

            if (Physics.Raycast(fpsCamera.transform.position, raycastDirection, out RaycastHit hitInfo, range))
            {
                Debug.Log($"distance: {hitInfo.distance}");
                Debug.DrawLine(fpsCamera.transform.position, hitInfo.point, Color.red, 30f);

                // TODO: нанести дамагарова
            }
        }
        catch (System.Exception e)
        {
            Debug.Log(e);
        }
    }

    private void HandleTriggerPulled()
    {
        if (!m_readyToShot)
        {
            return;
        }

        if (holdAllowed)
        {
            m_shooting = m_triggerHold;
        }
        else
        {
            m_shooting = m_triggerJustPressed;
        }

        if (!m_shooting || m_reloading || m_remainedBullets < 1)
        {
            return;
        }

        m_triggerJustPressed = false;

        m_readyToShot = false;
        m_remainedBullets--;

        // Выстреливаем все пули из выстрела (дробинки, например)
        for (uint i = 0; i < bulletsPerShot; i++)
        {
            Shoot();
        }

        Debug.Log($"Remains {m_remainedBullets} bullets");

        Invoke(nameof(ResetShot), shootingDelay);
    }

    private void ResetShot()
    {
        m_readyToShot = true;
    }

    void Update()
    {
        HandleTriggerPulled();
    }
}
