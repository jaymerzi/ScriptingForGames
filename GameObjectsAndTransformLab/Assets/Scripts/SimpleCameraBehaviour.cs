using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCameraBehaviour : MonoBehaviour
{

    public Transform target;

    public float camHeight;
    public float xOffset = 7f;
    private float xChange;
    public float zOffset = -9f;
    public float flipSpeed = -5f;
    private Vector3 velocity;
    private Transform thisTransform;
    private float oldPosition;
    private float newPosition;
    //private Transform thisTransform;

    // Update is called once per frame
    void Start()
    {
        thisTransform = transform;
        oldPosition = transform.position.x;
    }
    
    
    void Update()
    {
        newPosition = transform.position.x;
        if (newPosition < oldPosition)
        {
            xChange = -xOffset + (xOffset * 1.1f);
            oldPosition = transform.position.x;
        }
        
        if (newPosition > oldPosition)
        {
            xChange = xOffset;
            oldPosition = transform.position.x;
        }

        if (target.position.y > camHeight + 3f)
        {
            camHeight = target.position.y;
        }

        if (target.position.y < camHeight - 3f)
        {
            camHeight = target.position.y;
        }

        if (target.position.y < 2f)
        {
            camHeight = 2f;
        }

        transform.position = new Vector3(target.position.x + xChange, camHeight, 0f);
    }
}
