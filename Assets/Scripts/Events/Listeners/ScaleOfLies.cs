using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
public class ScaleOfLies : MonoBehaviour
{
    public UnityEvent Lie = new UnityEvent();
    
    // Start is called before the first frame update
    void Start()
    {
        Lie.AddListener(Listener);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Lie.Invoke();
        }
    }

    void Listener()
    {
        Debug.Log("Surely he ment well");
    }
}
