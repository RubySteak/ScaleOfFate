using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Chair : MonoBehaviour
{
    public UnityEvent event3 = new UnityEvent();
    
    // Start is called before the first frame update
    void Start()
    {
        event3.AddListener(Listener);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            event3.Invoke();
        }
    }

    void Listener()
    {
        Debug.Log("Chair has been spun");
    }
}
