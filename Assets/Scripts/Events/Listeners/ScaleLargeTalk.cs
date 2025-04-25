using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScaleLargeTalk : MonoBehaviour
{
    public UnityEvent TalkToScale = new UnityEvent();
    
    // Start is called before the first frame update
    void Start()
    {
        TalkToScale.AddListener(Listener);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TalkToScale.Invoke();
        }
    }

    void Listener()
    {
        Debug.Log("Scale has been pushed");
    }
}
