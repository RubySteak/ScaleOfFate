using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectScaleCount : MonoBehaviour
{
    public static CollectScaleCount I;

    public int scaleCount = 0;
    private void Start()
    {
        if (I == null)
        I = this;
    }

    public void AddScale()
    {
        scaleCount++;
    }
}
