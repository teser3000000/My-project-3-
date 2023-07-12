using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private Transform playerCamera;
    [SerializeField] private Transform playerBody;

    [SerializeField] private float mouseSensitivity = 1;

    private Vector2 _mouseInput;
    private Vector2 _rotation;

    private void Update()
    {
        //_mouseInput.x = Input.GetAxis("Mouse X");
        //_mouseInput.y = Input.GetAxis("Mouse Y");

        _rotation.x -= _mouseInput.y;
        _rotation.y += _mouseInput.x;

        _rotation.x = Mathf.Clamp(_rotation.x, -90, 90);

        playerCamera.localEulerAngles = Vector3.right * _rotation.x;
        playerBody.localEulerAngles = Vector3.up * _rotation.y;
    }

    public void OnLook(InputValue value)
    {
        _mouseInput = value.Get<Vector2>() * mouseSensitivity * Time.deltaTime;
    }
}
