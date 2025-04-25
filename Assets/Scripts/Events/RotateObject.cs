using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationAmount = 1f; // Amount to rotate in degrees

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Rotate();
        }
    }
    
    public void Rotate()
    {
        transform.Rotate(0, rotationAmount, 0);
    }
}