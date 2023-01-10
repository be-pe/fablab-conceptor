using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Catalog : MonoBehaviour
{
    public List<GameObject> assets;
    public GameObject button;

    public Canvas screen;
    // Start is called before the first frame update
    private void Start()
    {
        
        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo("./Assets/Resources/");
    
        var names  = dir.GetFiles("*.prefab");
        for (var index = 0; index < names.Length; index++)
        {
            var nm = Path.GetFileNameWithoutExtension(names[index].Name);
            Debug.Log(nm);
         
           GameObject instance = Instantiate(Resources.Load(nm, typeof(GameObject))) as GameObject;
            var temp = Instantiate(button, screen.transform);
            temp.GetComponent<ButtonHelper>().text.text = nm;
        }
    }
}
