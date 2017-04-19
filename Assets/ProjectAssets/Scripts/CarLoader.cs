using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CarLoader : MonoBehaviour, IInputClickHandler
{
    public void OnInputClicked(InputEventData eventData)
    {
        Debug.Log("Create the car");
    }

    // Use this for initialization
    void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
