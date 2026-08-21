using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Vector2 movement;
    Rigidbody rb;
    float moveSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 m_Input = new Vector3(movement.x, 0, movement.y);
        rb.MovePosition(transform.position + m_Input * Time.fixedDeltaTime * moveSpeed);
    }
    public void Move (InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
        Debug.Log(movement);
    }
}
