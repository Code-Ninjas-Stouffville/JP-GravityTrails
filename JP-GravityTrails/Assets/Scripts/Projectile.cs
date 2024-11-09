using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public Throwable direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectsWithTag("Player").GetComponent<Throwable>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += direction.offset * Time.deltaTime * speed;
    }
}
