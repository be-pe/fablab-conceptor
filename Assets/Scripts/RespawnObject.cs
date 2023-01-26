using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RespawnObject : MonoBehaviour
{
    public GameObject reference;
    public GameObject @object;

    // Update is called once per frame
    void Update()
    {
        if (@object == null)
        {
            @object = Instantiate(reference);
            Rigidbody rb = @object.AddComponent<Rigidbody>();

            rb.useGravity = false;
            rb.isKinematic = true;
            XRGrabInteractable gi = @object.AddComponent<XRGrabInteractable>();
            gi.movementType = XRBaseInteractable.MovementType.VelocityTracking;
            gi.useDynamicAttach = true;
            @object.transform.position = new Vector3(3.97300005f,0.699999988f,0);
        }
    }
}
