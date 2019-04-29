using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetBounty : MonoBehaviour
{
    string bounty;
    public GameObject[] players;
    public GameObject player;
    public Transform location;
    public int index;
    public Text bountyAmount;
    public int bountyNumber;
    // Start is called before the first frame update
    void Start()
    {
        index = Random.Range(0, players.Length);
        player = players[index];
        bountyNumber = Random.Range(50, 201);
        Instantiate(player, location.position, Quaternion.identity);
        bounty = player.name;
        PlayerPrefs.SetInt("Bounty", bountyNumber);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetString("Name", bounty);
        bountyAmount.text = bountyNumber.ToString();
    }
}
