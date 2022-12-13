using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float sideMoveSpeed;
    public Rigidbody rB;
    void FixedUpdate()
    {
        
        if (Input.GetKey("d"))
            rB.AddForce(sideMoveSpeed * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        if (Input.GetKey("a"))
            rB.AddForce(-sideMoveSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        
    }
}
