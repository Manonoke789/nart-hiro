using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private Rigidbody _rigidbody;
   private Animator _animator;

   public FixedJoystick FixedJoystick;
   [SerializeField] private float speed;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }


    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(FixedJoystick.Horizontal * speed, _rigidbody.velocity.y, FixedJoystick.Vertical * speed);

        Vector3 animationSpeed = new Vector3(FixedJoystick.Horizontal, _rigidbody.velocity.y, FixedJoystick.Vertical);
        _animator.SetFloat("speed", Vector3.ClampMagnitude(animationSpeed, 1).magnitude);

        if (FixedJoystick.Horizontal != 0 || FixedJoystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        }
    }
}
