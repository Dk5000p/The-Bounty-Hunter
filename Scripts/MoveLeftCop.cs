using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftCop : MonoBehaviour
{
    public Rigidbody2D rb;
    public int scene;

    // Update is called once per frame
    private void Start()
    {
        Destroy(gameObject, 1f);
    }
    void Update()
    {
        rb.AddForce(new Vector2(-30f, 0f));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Lives.lives -= 1;
            Destroy(gameObject);
        }
        if (collision.tag == "Forcefield")
        {
            Destroy(gameObject);
        }
    }
}
