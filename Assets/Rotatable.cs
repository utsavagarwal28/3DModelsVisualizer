using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rotatable : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 0.2f;

    private bool isDragging = false;
    private float currentYRotation = 0f;

    // Input Actions
    [SerializeField] private InputAction clickAction;
    [SerializeField] public InputAction rotateAction;

    private void OnEnable()
    {
        clickAction.Enable();
        rotateAction.Enable();

        clickAction.performed += OnClickPerformed;
        clickAction.canceled += OnClickReleased;
    }

    private void OnDisable()
    {
        clickAction.performed -= OnClickPerformed;
        clickAction.canceled -= OnClickReleased;
    }

    private void OnClickPerformed(InputAction.CallbackContext context) {isDragging = true;}

    private void OnClickReleased(InputAction.CallbackContext context) {isDragging = false;}

    private void Update()
    {
        if (isDragging)
        {
            if (!isDragging) return;

            Vector2 delta = rotateAction.ReadValue<Vector2>();
            float deltaX = delta.x;

            currentYRotation += -deltaX * rotationSpeed;


            transform.rotation = Quaternion.Euler(0f, currentYRotation, 0f);
        }
    }

}
