using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody rB;
    public float forwardSpeed;
    public float maxSpeed;
    private float speed;
    private float z;
    [HideInInspector]
    public float distance;
    
    void FixedUpdate()
    {
        distance = rB.position.z - z;
        speed = distance / Time.deltaTime;
        if (speed >= maxSpeed )
        {
            rB.AddForce(0, 0, -forwardSpeed * Time.deltaTime);
        }
        z = rB.position.z;
    }

}
