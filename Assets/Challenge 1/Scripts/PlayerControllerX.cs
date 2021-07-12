using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    private float verticalInput;

    public InputActionReference pitchAction;

    void OnEnable()
    {
        pitchAction.action.Enable();
    }

    void OnDisable()
    {
        pitchAction.action.Disable();
    }

    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = pitchAction.action.ReadValue<float>();

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
    }
}
