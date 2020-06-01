using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 arrow_keys;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        arrow_keys.x = Input.GetAxisRaw("Horizontal");
        arrow_keys.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + arrow_keys * speed * Time.fixedDeltaTime);
    }
}
