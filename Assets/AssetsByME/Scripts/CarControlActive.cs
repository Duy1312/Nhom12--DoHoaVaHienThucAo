using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CarControl;
    public GameObject DreamCar01;
    public GameObject DreamCar02;
    void Start()
{
    CarControl.GetComponent<CarController>().enabled = true;
    DreamCar01.GetComponent<CarAIControl>().enabled = true;
    DreamCar02.GetComponent<CarAIControl>().enabled = true;
}

  
}
