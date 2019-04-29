using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveDown : MonoBehaviour
{
    public Rigidbody2D rb;
    public int scene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector2(0f, -50f));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bounty")
        {
            Debug.Log("Hit");
            Score.score += PlayerPrefs.GetInt("Bounty");
            SceneManager.LoadScene(scene);
        }
        if (collision.tag == "Enemy")
        {
            Score.score += 10;
            Destroy(collision.gameObject);
        }

    }
}
