using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows.Speech;

public class PayLife : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();
    public AudioSource payBlood;
    public int scene;
    // Start is called before the first frame update
    void Start()
    {
        actions.Add("Yes", Yes);
        actions.Add("No", No);
        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
    }
    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            payBlood.Play();
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
    void Yes()
    {
        Lives.lives -= 1;
        Destroy(gameObject);
    }
    void No()
    {
        SceneManager.LoadScene(scene);
    }
}
