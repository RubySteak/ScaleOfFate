using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour
{
    public UnityEvent Escape = new UnityEvent();
    
    // Start is called before the first frame update
    void Start()
    {
        Escape.AddListener(Listener);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Escape.Invoke();
        }
    }

    void Listener()
    {
        Debug.Log("Scale 1 has been collected");
    }
}
