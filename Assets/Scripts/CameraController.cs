using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    private Transform playerPosition;
    private Transform cameraPosition;

    private void Start()
    {
        cameraPosition = GetComponent<Transform>();
        playerPosition = Player.GetComponent<Transform>();
    }
    private void Update()
    {
        cameraPosition.position = playerPosition.position + new Vector3(0, 5, -6);
        cameraPosition.rotation = Quaternion.Euler(30, 0, 0);
    }
}
