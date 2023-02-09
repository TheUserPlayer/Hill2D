using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelCar : MonoBehaviour
{
    
    public void OnTriggerEnter2D(Collider2D colision)
    {
        PlayGo.fuel = 1;
        Destroy(gameObject);
        Debug.Log("f");
    }

}
