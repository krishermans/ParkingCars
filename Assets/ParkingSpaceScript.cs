using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingSpaceScript : MonoBehaviour
{
    public GameObject Car;
	
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlaceCars()
    {
        Debug.Log("Place the cars");
        var headPosition = Camera.main;
        var carPosition = headPosition.transform.forward * 3.5f;
        var carRotation = headPosition.transform.rotation;
        for (int i = 0; i < 3; i++)
        {
            CreateCar(carPosition, carRotation);
            carPosition += headPosition.transform.right * 0.5f;
        }   
    }

    private void CreateCar(Vector3 position, Quaternion rotation)
    {
        var c = Instantiate(Car, position, rotation);
        c.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }
}
