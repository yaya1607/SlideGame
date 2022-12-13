using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement pM;
    public Rigidbody rB;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle" || collision.collider.tag == "TouchedObstacle")
        {
            pM.enabled = false;
            GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
            GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
            foreach (GameObject item in obstacles)
            {
                item.GetComponent<ObstacleMovement>().enabled = false;
            }
            foreach (GameObject item in coins)
            {
                item.GetComponent<ObstacleMovement>().enabled = false;
            }
            GameObject ground = GameObject.Find("Ground");
            ground.GetComponent<Spawner>().enabled = false;
            rB.constraints &= ~RigidbodyConstraints.FreezeRotationY;
        }
    }
    
}
