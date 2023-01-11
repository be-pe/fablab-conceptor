using UnityEngine;
using Valve.VR;

public class RayLaser : MonoBehaviour
{
    public SteamVR_Action_Boolean actionSet;
    // a reference to the hand
    public SteamVR_Input_Sources handType;
    public LayerMask layerMask;
    // See Order of Execution for Event Functions for information on FixedUpdate() and Update() related to physics queries
    public void Start()
    {
        actionSet.AddOnStateUpListener(TriggerDown, handType);
    }
    void TriggerDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            var helper = hit.collider.GetComponent<ButtonHelper>();
            if (helper is not null)
            {
                Debug.Log(hit.collider.name);
                helper.HandleClick();
            }
        }

    }
}
