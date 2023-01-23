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

    bool isActive = !catalog.activeSelf ;
    catalog.SetActive(isActive);
    catalog.transform.position = transform.forward + offset;
    // catalog.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2);
    catalog.transform.rotation = transform.rotation;
    
   }
}
