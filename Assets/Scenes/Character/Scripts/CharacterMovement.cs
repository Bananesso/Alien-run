using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        float movementDirection = Input.GetAxis("Vertical");
        if (movementDirection > 0)
        {
            _animator.SetBool("Walk", true);
        }
        else
        {
            _animator.SetBool("Walk", false);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _animator.SetBool("Run", true);
        }
        else
        {
            _animator.SetBool("Run", false);
        }
    }
}
