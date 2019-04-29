using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public static int lives;
    public int scene;
    public Text textLife;
    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        textLife.text = "Lives: " + lives.ToString();
        if (lives <= 0)
        {
            SceneManager.LoadScene(scene);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            lives -= 1;
        }
    }
}
