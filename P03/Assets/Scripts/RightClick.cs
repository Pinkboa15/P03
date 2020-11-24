﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightClick : MonoBehaviour
{
    [SerializeField] Camera cameraController;
    [SerializeField] Transform rayOrigin;
    [SerializeField] float shootDistance = 10f;
    RaycastHit objectHit;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        //calculate direction to shoot the ray 
        Vector3 rayDirection = cameraController.transform.forward;
        // cast a debug ray
        Debug.DrawRay(rayOrigin.position, rayDirection * shootDistance, Color.blue, 1f);
        //do the raycast
        if (Physics.Raycast(rayOrigin.position, rayDirection, out objectHit, shootDistance))
        {
            Debug.Log("You Hit the " + objectHit.transform.name);
        }
        else
        {
            Debug.Log("Miss.");
        }
    }
}