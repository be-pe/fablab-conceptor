using UnityEngine;
using UnityEngine.InputSystem;

public class CanvaSpawn : MonoBehaviour
{
    private Test spawn;
    public GameObject obj;
    public Vector3 vector;
    
    // Start is called before the first frame update
    void Awake()
    {
        spawn = new Test();
        spawn.Spawn.SpawnCanvas.performed += SpawnCanvasOnperformed;
    }

    private void SpawnCanvasOnperformed(InputAction.CallbackContext ctx)
    {
        var temp = Instantiate(obj, vector, Quaternion.Euler(0, 0, 0));
        temp.transform.localScale *= 0.01f;
    }

    void OnEnable()
    {
        spawn.Enable();
    }

    void OnDisable()
    {
        spawn.Disable();
    }
}
