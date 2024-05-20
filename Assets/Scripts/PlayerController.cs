using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private Rigidbody _rigidbody;
   private Animator _animator;

    [SerializeField] private FixedJoystick _fixedJoystick;
    [SerializeField] private float _speed;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }


    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_fixedJoystick.Horizontal * _speed, _rigidbody.velocity.y, _fixedJoystick.Vertical * _speed);

        Vector3 adimationSpeed = new Vector3(_fixedJoystick.Horizontal, _rigidbody.velocity.y, _fixedJoystick.Vertical);
        _animator.SetFloat("speed", Vector3.ClampMagnitude(adimationSpeed, 1).magnitude);

        if (_fixedJoystick.Horizontal != 0 || _fixedJoystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        }
    }
}
