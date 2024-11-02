﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Target Pos
    [Header("Target Object")]
    public Transform target;
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        //If target position on y axis
        if(target.position.y > transform.position.y)
        {
            //The camera will follow the targets position
            transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
        }
    }
}