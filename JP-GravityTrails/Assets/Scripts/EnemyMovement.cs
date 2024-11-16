using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;
    public float xForce;
    public float xDirection;
    private Rigidbody2D enemyRigidBody;
    public int maximumXPosition;
    public int minimumXPosition;
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Awake()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (transform.position.x < minimumXPosition)
        {
            xDirection = 1;
            enemyRigidBody.AddForce(Vector2.right * xDirection * 20);
        }
        if (transform.position.x > maximumXPosition)
        {
            xDirection = -1;
            enemyRigidBody.AddForce(Vector2.right * xDirection * 20);
        }
        enemyRigidBody.AddForce(Vector2.left * xForce* xDirection);
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "ThrowingObject")
        {
            Destroy(gameObject);
        }
    }
}
