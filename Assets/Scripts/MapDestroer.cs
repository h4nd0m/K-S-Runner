using UnityEngine;

public class MapDestroer : MonoBehaviour
{
    void Start()
    {
        Destroy(this.gameObject, 45f);
    }
}
