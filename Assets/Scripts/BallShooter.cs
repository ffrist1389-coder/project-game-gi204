using UnityEngine;

public class BallShooter : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform firePoint;
    public float mass = 1f;
    public float acceleration = 15f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (ballPrefab == null || firePoint == null) return;

        GameObject newBall = Instantiate(ballPrefab, firePoint.position, firePoint.rotation);
        Destroy(newBall, 5f);

        Rigidbody rb = newBall.GetComponent<Rigidbody>();
        if (rb != null)
        {
            float force = mass * acceleration;
            rb.AddForce(transform.forward * force, ForceMode.Impulse);

            rb.AddTorque(Vector3.up * 10f, ForceMode.Impulse);
        }
    }
}
