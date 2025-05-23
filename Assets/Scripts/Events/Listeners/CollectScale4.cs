using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class CollectScale4 : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.C))
        {
            UpdateScale.Invoke();
            Destroy(gameObject);
        }
    }

    void Listener()
    {
        Debug.Log("Scale 4 has been collected");
    }
}
