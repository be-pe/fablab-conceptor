using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class Catalog : MonoBehaviour
{
    public GameObject button;

    public GameObject screen;
    // Start is called before the first frame update
    private void Start()
    {
        var prefabs = Resources.LoadAll("Items", typeof(GameObject)).Cast<GameObject>();
        foreach (var item in prefabs)
        {
            var nm = item.name;
            var temp = Instantiate(button, screen.transform);
            var helper = temp.GetComponent<ButtonHelper>();
            helper.text.text = nm;
            helper.go = item;
        }

    }
}
