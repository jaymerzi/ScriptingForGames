using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public Rigidbody rigidbody;
public class FallBlockScript : MonoBehaviour
{

    public Vector3 originalPos;
    
    // Start is called before the first frame update
    void Start()
    {
        originalPos = gameObject.transform.position;
        GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Drop()
    {
        StartCoroutine(test());
    }

    IEnumerator test()
    {   
        yield return new WaitForSeconds(0.4f);
        GetComponent<Rigidbody>().useGravity = true;
        yield return new WaitForSeconds(3f);
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        yield return new WaitForSeconds(2f);
        gameObject.transform.position = originalPos;
    }
}
