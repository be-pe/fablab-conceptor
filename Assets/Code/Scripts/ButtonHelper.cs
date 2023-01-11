using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHelper : MonoBehaviour
{
    public Image preview;
    public TextMeshProUGUI text;
    public GameObject go;

    public void HandleClick() {
        GameObject instance = Instantiate(go);
    }
}
