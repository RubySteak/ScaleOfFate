using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class CollectScale2 : MonoBehaviour
{
    CollectScaleCount scalecounter;
    int scaleCounter; // Define scaleCounter as an integer

    // Start is called before the first frame update
    void Start()
    {
        scalecounter = GetComponent<CollectScaleCount>(); // Initialize scalecounter
        CollectScaleCount.I.scaleCount = scalecounter.scaleCount; // Access the scaleCount property/field
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            scaleCounter += 1; // Increment scaleCounter

            Destroy(gameObject); // Destroy the current GameObject
        }
    }

    void Listener()
    {
        Debug.Log("Scale 1 has been collected");
    }
}
