using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter;
    public Text collectableCounter;
    void Start()
    {
        collectableCounter.text = "0";
    }
    // Start is called before the first frame update
    void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            throwableCounter += 1;
            Destroy(collision.gameObject);
            collectableCounter.text = throwableCounter.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        collectableCounter.text = ""+throwableCounter;
        if (Input.GetButtonDown("Fire1"))
        {
            if (throwableCounter > 0)
            {
                offset = transform.localScale.x * new Vector3(1, 0, 0);
                Vector3 throwablePosition = transform.position + offset;
                GameObject ninjaStar = Instantiate(objectThrown, throwablePosition, transform.rotation);
                ninjaStar.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
                throwableCounter -= 1;
                collectableCounter.text = throwableCounter.ToString();

            }
        }
    }
}
