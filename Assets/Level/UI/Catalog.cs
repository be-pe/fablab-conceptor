using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Catalog : MonoBehaviour
{
    public GameObject button;

    public GameObject screen;
    // Start is called before the first frame update
    private void Start()
    {
        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo("./Assets/Resources/");
    
        var names  = dir.GetFiles("*.prefab");
        for (var index = 0; index < names.Length; index++)
        {
            var nm = Path.GetFileNameWithoutExtension(names[index].Name);
            Debug.Log(nm);
            var temp = Instantiate(button, screen.transform);
            var helper = temp.GetComponent<ButtonHelper>();
            helper.text.text = nm;
            helper.go = Resources.Load<GameObject>(nm);
        }
    }
}
