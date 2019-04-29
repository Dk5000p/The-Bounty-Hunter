using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTowards : MonoBehaviour
{
    public float speed = 5f;
    public Transform target;
    private void Start()
    {
       
    }
    private void Update()
    {
        target = GameObject.FindGameObjectWithTag("Bounty").transform;
        Vector2 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    }
}
