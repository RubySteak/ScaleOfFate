using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    
    
    private float xAxis;
    private float yAxis;

    float xAxisTurnRate = 400.0f;
    float yAxisTurnRate = 400.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Quaternion newRotation = Quaternion.Euler(xAxis, yAxis, 0.0f);

        Camera.main.transform.rotation = newRotation;
    }

    public void AddXAxisInput(float input)
    {
        xAxis += input * xAxisTurnRate;
        xAxis = Mathf.Clamp(xAxis, -90.0f, 90.0f);
    }

    public void AddYAxisInput(float input)
    {
       yAxis += input * yAxisTurnRate;
    }
}