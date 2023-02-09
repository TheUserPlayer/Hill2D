using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform Car;
    Vector3 Off;
     void Start() 
    {
      Off = transform.position - Car.position; 
    }
    void Update()
    {
        transform.position = Car.position + Off;
    }
}
