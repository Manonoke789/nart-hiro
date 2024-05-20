using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [SerializeField] private GameObject _inGameView;
    [SerializeField] private GameObject _player;

    private GameObject inGameView;
    private GameObject player;
    private GameObject Joystick;

    private PlayerController playerController;
    private FixedJoystick _fixedJoystick;

    private void Start()
    {
        player = Instantiate(_player, new Vector3(2, 0, 2), Quaternion.identity);
        playerController = player.GetComponent<PlayerController>();
        inGameView = Instantiate(_inGameView);
        Joystick = inGameView.transform.Find("Fixed Joystick").gameObject;
        _fixedJoystick = Joystick.GetComponent<FixedJoystick>(); 
        playerController._fixedJoystick = _fixedJoystick;


    }
}
