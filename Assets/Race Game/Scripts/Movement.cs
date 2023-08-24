using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]


public class Movement : MonoBehaviour
{

    private CharacterController controller;
    [SerializeField] private float playerSpeed = 2.0f;
    private Vector2 _playerInput;

    public void playerMove(InputAction.CallbackContext context)
    {
        _playerInput = context.ReadValue<Vector2>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        
        controller = gameObject.GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 move = new Vector3(_playerInput.y, 0, _playerInput.x * -1);
        controller.Move(move * Time.deltaTime * playerSpeed);
    
    }
}
