using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ToggleCatalog : MonoBehaviour
{
    public InputActionReference toggleReference;
    public Vector3 offset;
    public GameObject catalog;
    // Start is called before the first frame update
    private void Start()
    {
        catalog.SetActive(false);

    }
    private void Awake()
    {
        toggleReference.action.started += Toggle;

    }
    private void OnDestroy()
    {
        toggleReference.action.started -= Toggle;
    }
    private void Toggle(InputAction.CallbackContext context)
    {
        bool isActive = !catalog.activeSelf;
        catalog.SetActive(isActive);

        catalog.transform.position = transform.forward + offset;
        // catalog.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2);
        Quaternion lm = new Quaternion(0, transform.rotation.y - 180, 0, 0);
        catalog.GetComponent<RectTransform>().rotation= new Quaternion(catalog.transform.eulerAngles.x, catalog.transform.eulerAngles.y + 180, catalog.transform.eulerAngles.z,0);
        // catalog.transform.rotation = rotation;

    }
}
