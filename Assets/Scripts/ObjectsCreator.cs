using UnityEngine;

public class ObjectsCreator : MonoBehaviour
{
    [SerializeField] private GameObject inGameView;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject mainCamera;

    private GameObject _inGameView;
    private GameObject _player;
    private GameObject _joystick;
    private GameObject _mainCamera;

    private PlayerController _playerController;
    private CameraController _cameraController;
    private FixedJoystick _fixedJoystick;

    private void Start()
    {
        _mainCamera = Instantiate(mainCamera, new Vector3(2, 5, -4), Quaternion.identity);
        _player = Instantiate(player, new Vector3(2, 0, 2), Quaternion.identity);
        _inGameView = Instantiate(inGameView);

        _joystick = _inGameView.transform.Find("Fixed Joystick").gameObject;

        _cameraController = _mainCamera.GetComponent<CameraController>();
        _playerController = _player.GetComponent<PlayerController>();
        _fixedJoystick = _joystick.GetComponent<FixedJoystick>(); 

        _playerController.FixedJoystick = _fixedJoystick;
        _cameraController.Player = _player;

    }
}
