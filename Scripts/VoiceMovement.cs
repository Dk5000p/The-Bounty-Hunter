using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;

public class VoiceMovement : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();
    public static bool defense;
    public GameObject bullet;
    public GameObject bulletLeft;
    public GameObject bulletUp;
    public GameObject bulletDown;
    public Transform bulletLocation;
    public Animator anim;
    public static bool facingLeft;
    public static bool facingRight;
    public static bool facingUp;
    public static bool facingDown;
    public AudioSource bulletSound;
    // Start is called before the first frame update
    void Start()
    {
        facingLeft = false;
        facingRight = true;
        facingUp = false;
        defense = false;
        facingDown = false;
        actions.Add("right", Right);
        actions.Add("forward", Up);
        actions.Add("down", Down);
        actions.Add("left", Left);
        actions.Add("defend", Defend);
        actions.Add("fire", Fire);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
    }
    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }
    private void Up() 
    {
        defense = false;
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        anim.Play("forward");
        facingLeft = false;
        facingRight = false;
        facingUp = true;
        facingDown = false;
        if (defense == false)
        {
            transform.Translate(0, 1, 0);
        }
    }
    private void Right()
    {
        defense = false;
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        anim.Play("right");
        facingLeft = false;
        facingRight = true;
        facingUp = false;
        facingDown = false;
        if (defense == false)
        {
            transform.Translate(1, 0, 0);
        }
    }
    private void Left() {
        defense = false;
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        anim.Play("left");
        facingLeft = true;
        facingRight = false;
        facingUp = false;
        facingDown = false;
        if (defense == false)
        {
            transform.Translate(-1, 0, 0);
        }
    }
    private void Down()
    {
        defense = false;
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        anim.Play("down");
        facingLeft = false;
        facingRight = false;
        facingDown = true;
        facingUp = false;
        if (facingLeft == true)
        {
            anim.Play("downleft");
            facingLeft = true;
        }
        if (defense == false)
        {
            transform.Translate(0, -1, 0);
        }
    }
    private void Defend()
    {
        defense = true;
        if (defense == true)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
    private void Fire()
    {
        bulletSound.Play();
        if (facingRight == true)
        {
            Instantiate(bullet, bulletLocation.position, Quaternion.identity);
        }
        if (facingLeft == true)
        {
            Instantiate(bulletLeft, bulletLocation.position, Quaternion.identity);
        }
        if (facingUp == true)
        {
            Instantiate(bulletUp, bulletLocation.position, Quaternion.identity);
        }if (facingDown == true)
        {
            Instantiate(bulletDown, bulletLocation.position, Quaternion.identity);
        }
    }
}



