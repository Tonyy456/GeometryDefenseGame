using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private BoxCollider2D box;
    [SerializeField] private float speed = 1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    public void Move(Vector2 dir)
    {
        Vector2 dp_2d = dir * Time.deltaTime * speed;
        RaycastHit2D hit = Physics2D.BoxCast(rb.position, box.size, 0f, dp_2d, 1000f, 1);
        dp_2d = dp_2d.normalized * Math.Min(hit.distance, dp_2d.magnitude) ;
        rb.position += dp_2d;
        Debug.Log(dp_2d);
        //RaycastHit2D hit = Physics2D.Raycast(this.transform.position, new Vector2(dp_2d.x, 0));
        //RaycastHit2D hit = Physics2D.Raycast(this.transform.position, new Vector2(0, dp_2d.y));
    }
}
