using UnityEngine;
using System.Collections;

public class Kangaroo : MonoBehaviour 
{
    public float horizontalForce = 3f;  
    public float verticalForce = 200f;                  
    private bool isJumping = false;      
    private Animator anim;                   
    private Rigidbody2D rb;          


    void Start()
    {
        anim = GetComponent<Animator> ();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            isJumping = true;
            anim.SetBool("isJumping", true);
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(new Vector2(horizontalForce, 0), ForceMode2D.Force);

        if(isJumping == true)
        {
            isJumping = false;
            anim.SetBool("isJumping", false);
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0, verticalForce));     
        }
   
    }
}