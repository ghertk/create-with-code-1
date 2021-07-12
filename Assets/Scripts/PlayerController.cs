using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 45;
    private float horizontalInput;
    private float forwardInput;

    public InputActionReference turnAction;
    public InputActionReference accelerateAction;

    void OnEnable()
    {
        turnAction.action.Enable();
        accelerateAction.action.Enable();
    }

    void OnDisable()
    {
        turnAction.action.Disable();
        accelerateAction.action.Disable();
    }

    void Update()
    {
        horizontalInput = turnAction.action.ReadValue<float>();
        forwardInput = accelerateAction.action.ReadValue<float>();

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
