using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D body;
    private Animator anim;
    [SerializeField] private float speed;
    private bool grounded;
    private float horizontalInput;
    public GameObject winCanvas;
    public GameObject loseCanvas;
    // Start is called before the first frame update
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        speed = 10;
        grounded = false;
        winCanvas.SetActive(false);
        loseCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            body.velocity = new Vector2(body.velocity.x, speed);
            grounded = false;
        }
        if (horizontalInput > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        anim.SetBool("Walking", horizontalInput != 0);
        anim.SetBool("Grounded", grounded);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Flag") {
            winCanvas.SetActive(true);
            Time.timeScale = 0;
        }
        else if (collision.gameObject.tag == "Obstacle")
        {
            loseCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }
}