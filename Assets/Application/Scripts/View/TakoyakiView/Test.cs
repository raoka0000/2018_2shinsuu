﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public GameObject obj;
    public int suuzi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void MyEvent(){
         Instantiate(obj, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
