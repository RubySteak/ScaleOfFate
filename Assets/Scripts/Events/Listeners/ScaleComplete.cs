using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScaleComplete : MonoBehaviour
{
    public UnityEvent CheckScaleCount = new UnityEvent();

    CollectScaleCount scalecount;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("setScale", .2f);
 
        print(CollectScaleCount.I);
        print(GetComponent<CollectScaleCount>().scaleCount);
        CheckScaleCount.AddListener(Listener);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            print(1);
            if (scalecount.scaleCount == 4)
            {
                print(2);
                CheckScaleCount.Invoke();
            }
        }
    }

    void setScale()
    {
        CollectScaleCount.I.scaleCount = GetComponent<CollectScaleCount>().scaleCount;
    }

    void Listener()
    {
        Debug.Log("Wall destroyed");
    }
}
