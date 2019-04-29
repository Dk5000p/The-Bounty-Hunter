using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCreation : MonoBehaviour
{
    public GameObject[] bounties;
    public string bounty;
    public GameObject character;
    public Transform[] locations;
    public Transform location;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        index = Random.Range(0, locations.Length);
        location = locations[index];
        bounty= PlayerPrefs.GetString("Name");
        for (int i = 0; i < bounties.Length; i++)
        {
            character = bounties[i];
            if (character.name == bounty)
            {
                Instantiate(character, location.position, Quaternion.identity);
                character = GameObject.Find(bounty);
                character.tag = "Bounty";
                break;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
