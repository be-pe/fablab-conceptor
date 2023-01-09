using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Catalog : MonoBehaviour
{
    public List<GameObject> assets;
    public GameObject button;

    public Canvas screen;
    // Start is called before the first frame update
    private void Start()
    {
        for (var index = 0; index < assets.Count; index++)
        {
            var asset = assets[index];
            var temp = Instantiate(button, screen.transform);
            temp.GetComponent<ButtonHelper>().text.text = asset.name;
        }
    }
}
