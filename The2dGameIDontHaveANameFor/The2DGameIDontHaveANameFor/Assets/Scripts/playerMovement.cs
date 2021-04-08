using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Vector3 change;
    private Rigidbody2D playerRigidBody;
    private Animator animator;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if(change != Vector3.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveY", change.y);
            animator.SetFloat("moveX", change.x);
        }

    }

    void MoveCharacter()
    {
        playerRigidBody.MovePosition(transform.position + change * speed * Time.deltaTime);
    }
}
