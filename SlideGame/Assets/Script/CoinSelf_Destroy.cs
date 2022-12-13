using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSelf_Destroy : MonoBehaviour
{
    [SerializeField] GameObject coin;
    

    private int destroyPoint ;
    private void Start()
    {
        destroyPoint = (int)(GameObject.Find("Ground").transform.position.z - (GameObject.Find("Ground").transform.localScale.z/2));
        Debug.Log(destroyPoint);
    }
    void Update()
    {
        if(coin.transform.position.z <= destroyPoint)
        {
            Destroy(coin);
        }

    }
}
