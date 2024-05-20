using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [SerializeField] private GameObject _inGameView;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _camera;

    private GameObject inGameView;
    private GameObject player;
    private GameObject Joystick;
    private GameObject MainCamera;

    private PlayerController playerController;
    private CameraController cameraController;
    private FixedJoystick _fixedJoystick;

    private void Start()
    {
        MainCamera = Instantiate(_camera, new Vector3(2, 5, -4), Quaternion.identity);
        cameraController = MainCamera.GetComponent<CameraController>();
        player = Instantiate(_player, new Vector3(2, 0, 2), Quaternion.identity);
        playerController = player.GetComponent<PlayerController>();
        inGameView = Instantiate(_inGameView);
        Joystick = inGameView.transform.Find("Fixed Joystick").gameObject;
        _fixedJoystick = Joystick.GetComponent<FixedJoystick>(); 
        playerController._fixedJoystick = _fixedJoystick;
        cameraController.Player = player;



    }
}
