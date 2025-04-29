using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScaleComplete : MonoBehaviour
{
    public UnityEvent CheckScaleCount = new UnityEvent();

    private CollectScaleCount scaleCountComponent;

    // Start is called before the first frame update
    void Start()
    {
        // Assign the CollectScaleCount component to scaleCountComponent
        scaleCountComponent = GetComponent<CollectScaleCount>();
        if (scaleCountComponent == null)
        {
            Debug.LogError("CollectScaleCount component not found on the GameObject.");
        }

        // Optional: Add the Listener method to the UnityEvent
        CheckScaleCount.AddListener(Listener);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (scaleCountComponent != null)
            {
                print("Scales: " + scaleCountComponent.scaleCount);

                if (scaleCountComponent.scaleCount == 4) // Checks if the scaleCountComponent int is 4
                {
                    CheckScaleCount.Invoke();
                }
            }
            else
            {
                Debug.LogError("scaleCountComponent is null. Ensure it is assigned properly.");
            }
        }
    }

    void Listener()
    {
        Debug.Log("Wall destroyed");
    }
}