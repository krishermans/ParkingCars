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
        CreateCar();
    }

    private void CreateCar()
    {
        var c = Instantiate(Car);
    }
}
