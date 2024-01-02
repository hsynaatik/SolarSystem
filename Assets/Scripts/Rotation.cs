using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform planet;
    public float rotationSpeed = 1.0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.RotateAround(planet.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
