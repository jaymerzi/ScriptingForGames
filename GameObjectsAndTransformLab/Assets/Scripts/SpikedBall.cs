using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikedBall : MonoBehaviour
{
    public float speed = 3f;
    public bool spawned = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (spawned == true)
        {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Spawner")
        {
            spawned = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Spawner")
        {
            spawned = false;
        }
    }
}
