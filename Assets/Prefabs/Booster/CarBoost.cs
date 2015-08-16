﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;

public class CarBoost : MonoBehaviour {

    public GameObject playerCar;
    float start;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Booster"))
        {
            other.gameObject.SetActive(false);
            StartCoroutine(BoostCar(playerCar));
        }
        //Destroy(other.gameObject);
    }

    public IEnumerator BoostCar(GameObject playerCar) 
    {
        // Increase a player's car speed
        playerCar.GetComponent<CarController>().CurrentSpeed += 60.0f;

        yield return new WaitForSeconds(3f);

        // Decrease a player's car speed
        playerCar.GetComponent<CarController>().CurrentSpeed -= 10.0f;
        yield return new WaitForSeconds(0.2f);
        playerCar.GetComponent<CarController>().CurrentSpeed -= 10.0f;
        yield return new WaitForSeconds(0.2f);
        playerCar.GetComponent<CarController>().CurrentSpeed -= 10.0f;
        Debug.Log("in boostCar");
    }
}