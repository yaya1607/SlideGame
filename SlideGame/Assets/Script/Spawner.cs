using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	[System.Serializable]
	public class Point
	{
		public Transform[] point;
	}

	[System.Serializable]
	public class PointList
	{
		public Point[] style ;	
	}

	public PointList ListOfPointLists = new PointList();
	public PointList ListOfCoinPointLists = new PointList();
	public GameObject obstacle;
	public GameObject pirateCoin;

	private int rand;
	private bool coolDown = false;
	private GameObject ob ;
	private int count = 0;
	private int previous;
	void Start()
    {
		ob = SpawnObstacle(ListOfPointLists.style[0].point);
		SpawnCoin(ListOfCoinPointLists.style[0].point);
		rand = 2;
	}
    void Update()
	{
        //Try to get the position of the player to spawn the obstacles
        if ((int)ob.transform.position.z == 90 && coolDown == false )
        {
            ob = SpawnObstacle(ListOfPointLists.style[rand].point);
			SpawnCoin(ListOfCoinPointLists.style[rand].point);
            coolDown = true;
			//Random style of obstacles creation
			if (rand == 3 && previous != 4 && previous !=3) {
				previous = rand;
				rand = 4; 
			}
			else if (rand == 4 && previous != 4 && previous != 3) {
				previous = rand;
				rand = 3; 
				
			}
			else {
				previous = rand;
				rand = Random.Range(0, ListOfPointLists.style.Length); 
				
			}

        }
		if ((int)ob.transform.position.z == 90 && coolDown == true)
        {
			coolDown = false;
        }
		
    }
    private GameObject SpawnObstacle(Transform[] list)
    {
		GameObject last = new GameObject();
		foreach (Transform item in list)
		{
			//Get the right position to spawn the obstacles each 20f.
			Vector3 x = new Vector3(item.position.x, item.position.y, item.position.z - ListOfPointLists.style[rand].point[0].position.z + 100);
			GameObject pts = Instantiate(obstacle);
			pts.transform.position = x;
			last = pts;
		}
		return last;
	}
	private void SpawnCoin(Transform[] list)
	{
		foreach (Transform item in list)
		{
			//Get the right position to spawn the obstacles each 20f.
			Vector3 x = new Vector3(item.position.x, item.position.y, item.position.z - ListOfCoinPointLists.style[rand].point[0].position.z + 100);
			GameObject pts = Instantiate(pirateCoin);
			pts.transform.position = x;
		}
		
	}
}