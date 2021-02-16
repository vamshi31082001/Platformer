using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTransform;
    public GameObject xt;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //  playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {/*
        //assigning cameras position to temp
        Vector2 temp = transform.position;
        
        //assigning player position x to temp x
        temp.x = playerTransform.position.x;

        //offset of camera
        temp.x += offset;

        //assigning changed temp value to original camera position to change the original cam position
        transform.position = temp;
        */
        CameraFollow();



    }

    private void CameraFollow()
    {
        transform.position = playerTransform.position + offset;
        xt.transform.position = transform.position;
    }
}
