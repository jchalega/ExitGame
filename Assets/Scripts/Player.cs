using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] public float speed;

    [SerializeField] public Animator animator;
    private Rigidbody2D rigidbody2D;
    private SpriteRenderer spriteRenderer;  

    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Attack();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rigidbody2D.linearVelocity = direction.normalized * speed;
        if (direction != Vector2.zero)
        {
            animator.SetBool("isRunning", true);
            if (direction.x > 0)
            {
                spriteRenderer.flipX = false;
            }
            else if (direction.x < 0)
            {
                spriteRenderer.flipX = true;
            }

        }
        else
        {
            animator.SetBool("isRunning", false);
        }
        
      
        
            
        
    }

    private void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");
            return;
        }
        
                
        
    }
}
