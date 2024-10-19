using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    [SerializeField] private PlayerController controller;

    private InputSystem inputSystem;
    private InputAction move;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputSystem = new InputSystem();
        move = inputSystem.FindAction("Move");
        move.Enable();
    }

    private void FixedUpdate()
    {
        if (move.IsPressed()) OnMovePerformed();
    }

    void OnMovePerformed()
    {
        Vector2 keyPressDir = move.ReadValue<Vector2>();
        controller?.Move(keyPressDir);
    }
}
