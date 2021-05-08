using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Rigidbody rb;

    public float speed = 10f;
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(x, 0, z).normalized;

        controller.Move(movement * speed * Time.deltaTime);

        if (movement.magnitude != 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(-movement);
            transform.localRotation = targetRotation;
        }
        
    }

 
}
