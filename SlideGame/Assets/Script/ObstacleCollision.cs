using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public ObstacleMovement oM;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player" || collision.collider.tag == "TouchedObstacle")
        {
            oM.enabled = false;
            transform.gameObject.tag = "TouchedObstacle";

        }
        
    }
    

}
