using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody head;
    public float moveSpeed = 50.0f;
    private CharacterController characterController;
 
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

  
    void Update()
    {
        void FixedUpdate()
        {
            Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"),
  0, Input.GetAxis("Vertical"));
            if (moveDirection == Vector3.zero)
            {
                // TODO
            }
            else
            {
                head.AddForce(transform.right * 150, ForceMode.Acceleration);
            }
        }

        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterController.SimpleMove(moveDirection * moveSpeed);
    }
}
