using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController characterController;
    public float speed;
    InputSystem_Actions input;
    Vector3 movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        input = new InputSystem_Actions();
        input.movement.Enable();
    }

    private void OnDestroy()
    {
        input.movement.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = input.movement.move.ReadValue<Vector2>().x;
        movement.z = input.movement.move.ReadValue<Vector2>().y;

        characterController.Move(Time.deltaTime * speed * movement);
    }
}
