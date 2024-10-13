using UnityEngine;

public class BaseGrenade : MonoBehaviour
{
    public float explosionTimeout = 3.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke(nameof(Explode), explosionTimeout);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void Explode()
    {
        Debug.Log($"{nameof(Explode)}");

        Destroy(gameObject);
    }
}
