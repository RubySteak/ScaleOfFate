using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScaleLarge : MonoBehaviour
{
    public UnityEvent PushLargeScale = new UnityEvent();
    
    // Start is called before the first frame update
    void Start()
    {
        PushLargeScale.AddListener(Listener);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PushLargeScale.Invoke();
        }
    }

    void Listener()
    {
        Debug.Log("Scale has been pushed");
    }
}
