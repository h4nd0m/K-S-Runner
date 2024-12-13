using UnityEngine;

public class CamPos : MonoBehaviour
{
    [SerializeField] private Transform _player;

    private void Update()
    {
        if (_player != null)
        {
            Vector3 target = new Vector3(_player.position.x, transform.position.y, -10);
            transform.position = target;
        }
    }
}
