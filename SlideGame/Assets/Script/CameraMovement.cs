using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Player;
    public Vector3 Offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position + Offset;
    }
}
