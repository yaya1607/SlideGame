using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSelf_Destroy : MonoBehaviour
{
    public GameObject obstacle;
    private void OnCollisionExit(Collision collision)
    {
        if(collision.collider.name == "Ground")
        {
            Destroy(obstacle);
        }
    }
}
