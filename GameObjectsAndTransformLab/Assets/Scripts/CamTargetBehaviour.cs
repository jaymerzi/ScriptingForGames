using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTargetBehaviour : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 3f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }
}
