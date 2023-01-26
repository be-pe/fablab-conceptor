using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ToggleCatalog : MonoBehaviour
{
    public InputActionReference toggleReference;
    public float offset;
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
        Debug.Log(toggleReference.name);
        bool isActive = !catalog.activeSelf;
        catalog.SetActive(isActive);

        var temp = catalog.transform.position;
        var t = Camera.main.transform;
        temp = t.position + t.forward * offset;
        temp.y = t.position.y - 0.2f;

        catalog.transform.position = temp;
        catalog.transform.rotation = new Quaternion(0, t.rotation.y, 0, t.rotation.w);
    }
}
