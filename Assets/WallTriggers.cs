using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WallTriggers : MonoBehaviour
{
    public XRRayInteractor rayInteractor;
    public bool contact = false;
    private Vector3 lastPosition;
    private float current;
    private Vector3 currentPosition;
    public XRInteractorLineVisual patate;
    public XRRayInteractor pomme;
    public GameObject leftHand;
    private Vector3 positionHandTrigger;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (!contact)
        {
            current = patate.lineLength;
            currentPosition = this.transform.position;
            
        }
        /*else
        {
          Vector3 ecart = leftHand.transform.position-positionHandTrigger;
          this.transform.position -= ecart;
        }*/
        
    }

    private void OnTriggerEnter(Collider other)
    {
        contact = true;
        patate.lineLength = current;
        pomme.translateSpeed = 0f;
        Debug.Log("enter");
        positionHandTrigger  = leftHand.transform.position;


        //this.transform.position=currentPosition;

    }
    /*private void OnTriggerStay(Collider other){
        this.transform.position=currentPosition;
    }*/

    private void OnTriggerExit(Collider other)
    {
        contact = false;
        patate.lineLength = 100f;
        pomme.translateSpeed = 1f;
        Debug.Log("exit");
    }



}
