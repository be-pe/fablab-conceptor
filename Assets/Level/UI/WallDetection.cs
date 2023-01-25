using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class WallDetection : MonoBehaviour
{
    public void OnTriggerEnter(Collider other){
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        Debug.Log(rb.useGravity);
    }

    public void OnTriggerStay(Collider other){
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        Debug.Log(rb.useGravity);
    }

    public void OnTriggerExit(Collider other){
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        Debug.Log(rb.useGravity);
    }
}
