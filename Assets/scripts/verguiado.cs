using UnityEngine;
using UnityEngine.InputSystem;

public class verguiado : MonoBehaviour
{
    private bob bob;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.TryGetComponent(out bob);
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            bob.minhealth();
        }

        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            bob.maxhealth();
        }
    }
}
