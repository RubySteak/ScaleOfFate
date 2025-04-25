using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectScale3 : MonoBehaviour
{
    public UnityEvent CollectScale = new UnityEvent();
    
    // Start is called before the first frame update
    void Start()
    {
        CollectScaleCount.I.scaleCount = GetComponent<CollectScaleCount>().scaleCount;
        
        CollectScale.AddListener(Listener);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            CollectScale.Invoke();

            CollectScaleCount.I.scaleCount += 1;

            Destroy(gameObject);
        }
    }

    void Listener()
    {
        Debug.Log("Scale 1 has been collected");
    }
}
