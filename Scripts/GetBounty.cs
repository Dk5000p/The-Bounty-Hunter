using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBounty : MonoBehaviour
{
    public string bounty1;
    public GameObject bountyTarget;
    // Start is called before the first frame update
    void Start()
    {
        bounty1=PlayerPrefs.GetString("Name");
        
        Debug.Log(bounty1);
    }

    // Update is called once per frame
    void Update()
    {
        bountyTarget= GameObject.Find(bounty1);
        bountyTarget.tag = "Bounty";
    }
}
