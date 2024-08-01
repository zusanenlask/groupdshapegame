using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float speed;
    private bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        speed = 10;
        grounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal")*speed,body.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space)) {
            body.velocity = new Vector2(body.velocity.x, speed);
            grounded = false;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Ground") {
            grounded = true;
        }
    }
}
