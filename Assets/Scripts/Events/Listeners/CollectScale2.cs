using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class CollectScale2 : MonoBehaviour
{
    public UnityEvent UpdateScale = new UnityEvent();
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateScale.AddListener(Listener);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            UpdateScale.Invoke();
            Destroy(gameObject);
        }
    }

    void Listener()
    {
        Debug.Log("Scale 2 has been collected");
    }
}
