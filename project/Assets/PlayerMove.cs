using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float Speed;
    public float JumpSpeed;


    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Rigidbody.AddRelativeTorque(-Vector3.forward * Speed, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Rigidbody.AddRelativeTorque(Vector3.forward * Speed, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.AddForce(Vector3.up * JumpSpeed, ForceMode.VelocityChange);
        }
    }
}
