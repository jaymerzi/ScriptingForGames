using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyBall : MonoBehaviour
{
    public float bounceForce = 10f;
    public Color newColor = Color.green;
    public float shrinkFactor = 0.2f;

    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        GetComponent<Renderer>().material.color = newColor;
        transform.localScale *= shrinkFactor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
