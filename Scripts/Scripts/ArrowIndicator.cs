using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowIndicator : MonoBehaviour
{
    public GameObject target;
    public Transform targetTransform;

    void Start()
    {
        
    }

    void Update()
    {
        target = GameObject.FindWithTag("Bounty");
        var dir = target.transform.position- transform.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle-90, Vector3.forward);
    }
}
