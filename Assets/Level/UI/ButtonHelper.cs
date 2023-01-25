using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonHelper : MonoBehaviour
{
    public Image preview;
    public TextMeshProUGUI text;
    public GameObject go;
    public Vector3 spawnPosition;
    public void HandleClick()
    {
        GameObject instance = Instantiate(go, spawnPosition, Quaternion.identity);
        instance.layer = 9;

        Rigidbody rb = instance.AddComponent<Rigidbody>();
        rb.useGravity  = false;
        rb.isKinematic = true;
        // instance.AddComponent<WallDetection>();
        XRGrabInteractable gi = instance.AddComponent<XRGrabInteractable>();
        gi.movementType = XRBaseInteractable.MovementType.VelocityTracking;
        gi.useDynamicAttach = true;
    }
}
