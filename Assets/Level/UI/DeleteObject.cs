using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DeleteObject : MonoBehaviour
{

    public InputActionReference toggleReference;
    private GameObject obj;

    public void Start(){
        // toggleReference.name = "XRI RightHand Interaction/Menu";
        
    }

    public void Update(){
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)){
            if (hit.collider.gameObject.layer == 9){
                Debug.Log("oop");
                obj = hit.collider.gameObject;              
                toggleReference.action.started += Delete;
            }
        }
    }
  
    public void Delete(InputAction.CallbackContext context)
    {
         Debug.Log("j'appuie");
        Destroy(obj);
    }
}
