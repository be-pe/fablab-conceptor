using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Code.Scripts
{
    public class Highlightable : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        private Outline outline;
        private void Awake()
        {
            outline = this.AddComponent<Outline>();
            outline.enabled = true;
            outline.OutlineColor = Color.green;
            outline.OutlineWidth = 10;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            Debug.Log("Pointer in.");
            outline.enabled = true;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            Debug.Log("Pointer out.");
            outline.enabled = false;
        }
    }
}
