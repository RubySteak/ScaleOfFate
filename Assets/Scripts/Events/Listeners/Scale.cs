using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Scale : MonoBehaviour
{
    public UnityEvent DestroyWall = new UnityEvent();
    
    // Start is called before the first frame update
    void Start()
    {
        DestroyWall.AddListener(Listener);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            DestroyWall.Invoke();
        }
    }

    void Listener()
    {
        Debug.Log("Wall destroyed");
    }
}
