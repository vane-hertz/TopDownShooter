using UnityEngine;

public class BulletDespawner : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (IsOffScreen())
        {
            Destroy(gameObject);
        }
    }

    bool IsOffScreen()
    {
        Vector3 bulletScreenPos = mainCamera.WorldToScreenPoint(transform.position);
        if (bulletScreenPos.x < 0 || bulletScreenPos.x > Screen.width || bulletScreenPos.y < 0 || bulletScreenPos.y > Screen.height)
        {
            return true;
        }
        return false;
    }
}