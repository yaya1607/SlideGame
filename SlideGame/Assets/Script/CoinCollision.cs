using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollision : MonoBehaviour
{
    static public  int score = 0;
    [SerializeReference]
    private GameObject coin;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            score ++ ;
            Destroy(coin);
        }
    }
}
