using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    //Rigidbody 2D
    [Header("Rigidbody")]
    public Rigidbody2D rb;
    [Header("Default Down Speed")]
    //Down Speed
    public float downSpeed = 20f;
    [Header("Default Movement Speed")]
    //Move Speed
    public float movementSpeed = 10f;
    [Header("Default Directional Movement Speed")]
    //movement direction of the object
    public float movement = 0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //variable equals to component Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
        //movement equals horizontal move
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        //if direction on x axis is less than 0
        if (movement < 0)
        {
            //object faces left
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        //if direction on x axis is greater than 0
        else
        {
            //object faces right
            this.GetComponent <SpriteRenderer>().flipX = true;
        }

        //Position stuff idk
        if (rb.velocity.y > 0 && transform.position.y > topScore)
        {
            //score equals player pos
            topScore = transform.position.y;
        }
        //text for score
        scoreText.text = "Score: " + Mathf.Round(topScore).ToString();
    }
    void FixedUpdate()
    {
        //Vector 2
        Vector2 velocity = rb.velocity;
        //vel of x
        velocity.x = movement;
        //rb vel = to vel of object
        rb.velocity = velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //vel w the downspeed
        rb.velocity = new Vector3(rb.velocity.x, downSpeed, 0);
    }
    //Game Over Canvas
    [Header("Game Over UI Canvas Object")]
    public GameObject gameOverCanvas;

    //Game over function
    public void GameOver()
    {
        //Game Over Canvas is active
        gameOverCanvas.SetActive(true);
    }
    [Header("Score Text")]
    public Text scoreText;

    //score of gaem
    private float topScore = 0.0f;
}
