using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    private float bulletSpeed = 20f;
    private float fireRate = 0.2f;
    private float fireCoolDown = 0.0f;
    public GameObject player;
    void Update()
    {
        if (Input.GetMouseButton(0) && fireCoolDown <= 0.0f)
        {
            GameObject bullet = Instantiate(bulletPrefab, player.transform.position, Quaternion.identity);
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            Vector2 direction = new Vector2(mousePosition.x - bullet.transform.position.x, mousePosition.y - bullet.transform.position.y);
            direction.Normalize();

            bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

            fireCoolDown = fireRate;
        }
        else
        {
            fireCoolDown -= Time.deltaTime;
        }
    }
}