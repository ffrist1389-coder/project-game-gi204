using UnityEngine;

public class AirResistance : MonoBehaviour
{
    public float drag = 0.2f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(-rb.linearVelocity * drag);
    }
}
