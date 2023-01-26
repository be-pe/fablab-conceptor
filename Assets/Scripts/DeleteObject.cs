using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class DeleteObject : MonoBehaviour
{

    public InputActionReference toggleReference;
    private GameObject obj;
    public List<XRBaseInteractor> interactors;

    public void Start()
    {
        toggleReference.action.started += Delete;
    }

    public void Delete(InputAction.CallbackContext context)
    {
        foreach (var interactor in interactors)
        {
            if (interactor.isSelectActive)
            {
                foreach (var item in interactor.interactablesSelected.ToArray())
                {
                    Destroy(item.transform.gameObject);
                }
            }

        }
    }
}
