using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class SecretScale2 : MonoBehaviour
{
    public UnityEvent Secret2 = new UnityEvent();
    
    // Start is called before the first frame updat
    void Start()
    {
        Secret2.AddListener(Listener);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            Secret2.Invoke();
        }
    }

    void Listener()
    {
        Debug.Log("Scale 1 has been collected");
    }
}
