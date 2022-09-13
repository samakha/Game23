using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyJoystick;
using UnityEngine.SceneManagement; 
public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public Joystick joystick;

    public float moveSpeed;
    Vector2 moveInput;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        moveInput.x = joystick.Horizontal();
        moveInput.y = joystick.Vertical();

        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
