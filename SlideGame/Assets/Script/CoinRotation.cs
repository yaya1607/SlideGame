using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public Transform transform;
    private float time=0;
    void Update()
    {
        time += Time.deltaTime;
        
        if(time >= 0.1)
        {
            transform.Rotate(0,0,10,Space.Self);
            time = 0;
        }
            
    }
}
