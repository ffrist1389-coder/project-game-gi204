using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private Vector3 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        moveInput = (transform.right * h + transform.forward * v).normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(
            moveInput.x * moveSpeed,
            rb.linearVelocity.y,
            moveInput.z * moveSpeed
        );
    }
}
