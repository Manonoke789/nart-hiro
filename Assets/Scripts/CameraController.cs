using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    private Transform _playerPosition;
    private Transform _cameraPosition;

    private void Start()
    {
        _cameraPosition = GetComponent<Transform>();
        _playerPosition = Player.GetComponent<Transform>();
        _cameraPosition.rotation = Quaternion.Euler(30, 0, 0);
    }
    private void Update()
    {
        _cameraPosition.position = _playerPosition.position + new Vector3(0, 5, -6);
    }
}
