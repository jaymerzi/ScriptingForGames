using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipTransformBehaviour : MonoBehaviour
{
    //public KeyCode key1 = KeyCode.RightArrow, key2 = KeyCode.LeftArrow;
    public float direction1 = 0, direction2 = 180;
    private Transform thisTransform;
    private float oldPosition;
    private float newPosition;

    // Start is called before the first frame update
    void Start()
    {
        thisTransform = transform;
        oldPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position.x;
        if (newPosition < oldPosition)
        {
            transform.rotation = Quaternion.Euler(0, direction2, 0);
            oldPosition = transform.position.x;
        }

        if (newPosition > oldPosition)
        {
            transform.rotation = Quaternion.Euler(0, direction1, 0);
            oldPosition = transform.position.x;
        }
        
        /*if (velocity.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, direction1, 0);
        }
        
        if (velocity.x <0)
        {
        transform.rotation = Quaternion.Euler(0, direction2, 0);
        }
        
        if (Input.GetKeyDown(key1))
        {
            transform.rotation = Quaternion.Euler(0, direction1, 0);
        }

        if(Input.GetKeyDown(key2))
        {
        transform.rotation = Quaternion.Euler(0, direction2, 0);
        }*/
    }
}
