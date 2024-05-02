using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int speed;
    private Rigidbody2D rb;
    private Vector2 control;
    private Vector2 enlargedScale = new Vector2(1f, 1f);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mover = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        control = mover.normalized * speed;
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + control * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "food") {
            transform.localScale = enlargedScale;

        }
    }
}
