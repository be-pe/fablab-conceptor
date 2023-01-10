using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Valve.VR;

public class PopCatalog : MonoBehaviour
{
    // a reference to the action
    public SteamVR_Action_Boolean isActive;
    // a reference to the hand
    public SteamVR_Input_Sources handType;
    //reference to the Catalog
    public GameObject Catalog;
    private GameObject instance;
    private bool state = false ;
    public float x,y,z;
    // Start is called before the first frame update
    void Start()
    {
        isActive.AddOnStateUpListener(TriggerUp, handType);
    }

    public void TriggerUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Trigger is up");
        if (state)
        {
            Destroy(instance);
            instance = null;
            // Delete instance
        } else {
            instance = Instantiate(Catalog);
            instance.transform.parent = transform;
            instance.transform.localPosition = new Vector3(x,y,z) * 1;
            instance.transform.rotation = Quaternion.Euler(0,0,0);
            // Créer instance
        }
        state = !state;
    }
}
