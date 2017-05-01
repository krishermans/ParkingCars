using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ParkingLotApi.Models;
#if UNITY_UWP
using System.Net.Http;
using Newtonsoft.Json;
#endif

public class ParkingSpaceScript : MonoBehaviour
{
    public GameObject Car;

    private int numberOfCars;

    // Use this for initialization
	void Start ()
    {
#if UNITY_UWP
        var uri = new Uri("https://parkinglot-smacos-beta.azurewebsites.net/api/ParkingLots");
        var client = new HttpClient();
        var resultstring = client.GetStringAsync(uri).Result;
        Debug.Log(resultstring);
        var resultList = JsonConvert.DeserializeObject<List<ParkingLot>>(resultstring);
        numberOfCars = resultList.Count;
#endif
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
