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
        Rigidbody rb = instance.AddComponent<Rigidbody>();
        XRGrabInteractable gi = instance.AddComponent<XRGrabInteractable>();
    }
}
