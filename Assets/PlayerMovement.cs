using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);
        
        controller.Move(movement * moveSpeed * Time.deltaTime);
    }
}
