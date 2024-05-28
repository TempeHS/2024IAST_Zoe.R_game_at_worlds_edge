using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private LayerMask groundLayer; 
    private Rigidbody2D body;
    private Animator anim;
    private BoxCollider2D boxCollider;
    
    private void Awake()
    {   
    //i think this is the part that stops you from noclipping into the backrooms
    body = GetComponent<Rigidbody2D>();
    //not this part
    anim = GetComponent<Animator>();
    boxCollider = GetComponent<BoxCollider2D>();
    }
 
    private void Update()
    {
    //movement
    float horizontalinput = Input.GetAxis("Horizontal");
    body.velocity = new Vector2(horizontalinput * speed, body.velocity.y);
 
    //flip character when moving left and right
    if(horizontalinput > 0.01f)
        transform.localScale = new Vector3(1, 1, 1);
    else if(horizontalinput < -0.01f)
        transform.localScale = new Vector3(-1, 1, 1);
    
     //jump
    if (Input.GetKey(KeyCode.Space) && isGrounded())
        Jump();

    //animations
    anim.SetBool("run", horizontalinput != 0);
    anim.SetBool("grounded", isGrounded());
    }
    
    //more jumpng code
    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
        anim.SetTrigger("jump");
    }
 
    //checking if the player is on the ground
    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    private bool isGrounded()
    {
       RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
       return raycastHit.collider != null;
    }

     private bool onWall()
    {
       RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
       return raycastHit.collider != null;
    }
}
