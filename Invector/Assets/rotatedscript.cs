﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatedscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
 
     private Vector3 _rotation;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotation * Time.deltaTime);
    }
}
