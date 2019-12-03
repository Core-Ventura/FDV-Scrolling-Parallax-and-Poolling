using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTile : MonoBehaviour 
{
    private Rigidbody2D rb;
    public float speed = 1f;
    // Use this for initialization
    void Start () 
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2 (speed*-1, 0);
    }

}