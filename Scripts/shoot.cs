using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet;
    public float timeSecs;
    public Transform bulletLocation;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 0, timeSecs);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Fire()
    {
        Instantiate(bullet, bulletLocation.position, Quaternion.identity);
    }
}
