using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    private Animator _animator;
    private Rigidbody _rb;

    //public float jumpForce;
    //public bool isGrounded;
    //LayerMask layerMask = LayerMask.GetMask("Wall", "Character");

    public float speed = 0.5f;
    public float rotationSpeed = 100.0f;
    private float _speed;

    [SerializeField] private float _maxSpeed;
    private void Start()
    {
        _speed = _maxSpeed;
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);

        transform.Rotate(0, rotation, 0);

        float movementDirection = Input.GetAxis("Vertical");

        _animator.SetBool("walk", movementDirection > 0);
        _animator.SetBool("run", Input.GetKey(KeyCode.LeftShift));

        if (movementDirection > 0)
        {
            _rb.AddForce(transform.forward * _speed, ForceMode.Impulse);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                _rb.AddForce(transform.forward * _speed * 2, ForceMode.Impulse);
            }
        }

        //RaycastHit hit;

        //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))

        //{
        //    isGrounded = true;
        //    if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        _rb.AddForce(new Vector3(_rb.velocity.x, jumpForce), ForceMode.Impulse);
        //    }
        //}
        //else
        //{
        //    isGrounded = false;
        //}

        //_animator.SetBool("isGrounded", !isGrounded);

        ClampVelocity();
    }

    private void ClampVelocity()
    {
        float velocity = _rb.velocity.magnitude;

        if (velocity > _maxSpeed)
        {
            Vector3 movementDirection = _rb.velocity.normalized;
            _rb.velocity = movementDirection * _maxSpeed;
        }
    }
}
