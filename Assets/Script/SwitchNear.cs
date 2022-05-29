using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchNear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        var parent = transform.parent;
        for (int i = 0; i < transform.parent.childCount; i++)
        {
            parent.GetChild(i).gameObject.SetActive(parent.GetChild(i)==transform);
        }
    }
}
