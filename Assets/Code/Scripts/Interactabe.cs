using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Interactabe : MonoBehaviour
{
   public SteamVR_Action_Boolean actionSet;
    // a reference to the hand
    public SteamVR_Input_Sources handType;
    public LayerMask layerMask;
    private bool isDrag = false;
    // See Order of Execution for Event Functions for information on FixedUpdate() and Update() related to physics queries
    public void Start()
    {
        actionSet.AddOnStateUpListener(TriggerDown, handType);
    }
    public void Update()
    {
        if(isDrag){
            
        }
    }
    void TriggerDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            isDrag = true;
            
        }

    }

}
