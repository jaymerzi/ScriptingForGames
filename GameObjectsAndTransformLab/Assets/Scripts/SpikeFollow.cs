using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeFollow : MonoBehaviour
{
    public Transform target;
    public float yDisplacement = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position;
        transform.position = new Vector3(target.position.x, target.position.y + yDisplacement, 0f);
    }
}
