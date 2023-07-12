using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private float movespeed;
    [SerializeField] private float gravityForce = -3f;

    private Vector3 _velocity;
    private Vector2 _keyboardInput;

    private void Update()
    {
        //_keyboardInput.x = Input.GetAxis("Horizontal");
        //_keyboardInput.y = Input.GetAxis("Vertical");

        _velocity = transform.forward * _keyboardInput.y + transform.up * gravityForce + transform.right * _keyboardInput.x;
        _velocity.Normalize(); 
        _velocity *= movespeed * Time.deltaTime;

        _velocity.y = gravityForce; 

        controller.Move(_velocity);



        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E");
        }
    }
    private void OnMove(InputValue value)
    {
        _keyboardInput = value.Get<Vector2>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Respawn"))
        {
            Debug.Log(other.gameObject.name);
        }
    }
}
