using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 200f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        transform.Rotate(0f, mouseX, 0f);
    }
}