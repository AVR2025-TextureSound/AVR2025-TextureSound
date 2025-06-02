using UnityEngine;
using UnityEngine.InputSystem;

public class FlyMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 5f;

    // Diese Felder müssen public und vom Typ InputActionProperty sein!
    public InputActionProperty moveAction;
    public InputActionProperty flyVerticalAction;

    void Update()
    {
        Vector2 move2D = moveAction.action.ReadValue<Vector2>();
        float moveY = flyVerticalAction.action.ReadValue<float>();

        Vector3 move = transform.right * move2D.x + transform.forward * move2D.y + transform.up * moveY;
        controller.Move(move * speed * Time.deltaTime);
    }

    void OnEnable()
    {
        moveAction.action.Enable();
        flyVerticalAction.action.Enable();
    }
    void OnDisable()
    {
        moveAction.action.Disable();
        flyVerticalAction.action.Disable();
    }
}
