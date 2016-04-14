﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WaterBottleController : MonoBehaviour {

	public Scrollbar waterBar;
	public GameObject minimapBottle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.down * Time.deltaTime * 100);
		minimapBottle.transform.Rotate(Vector3.down * Time.deltaTime * 100);
		//transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
	}

	void OnTriggerEnter(Collider other)
	{
		
		if(other.tag == "Player" && other.GetType() == typeof(BoxCollider))
		{
			Destroy (gameObject);
			Destroy (minimapBottle);
			waterBar.size = 1;
			PlayerController.water = PlayerController.initialWater;
		}

	}

}
