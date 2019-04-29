using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public Transform[] locations;
    public int index;
    public int enemyindex;
    public GameObject[] enemies;
    public GameObject enemy;
    public Transform location;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < locations.Length; i++)
        {
            enemyindex = Random.Range(0, enemies.Length);
            enemy = enemies[enemyindex];
            location = locations[i];
            Instantiate(enemy, location.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
