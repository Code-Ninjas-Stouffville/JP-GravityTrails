using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter;
    public Throwable direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectsWithTag("Player").GetComponent<Throwable>();
    }
    void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            throwableCounter += 1;
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (throwableCounter > 0)
            {
                offset = transform.localScale.x * new Vector3(1, 0, 0);
                Vector3 throwablePosition = transform.position + offset;
                GameObject ninjaStar = Instantiate(objectThrown, throwablePosition, transform.rotation);
                ninjaStar.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
                throwableCounter -= 1;
            }
        }
    }
}
