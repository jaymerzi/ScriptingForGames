using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public Rigidbody rigidbody;
public class FallBlockScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
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
        yield return new WaitForSeconds(0.2f);
        GetComponent<Rigidbody>().useGravity = true;
        yield return new WaitForSeconds(5f);
        GetComponent<Rigidbody>().useGravity = false;
    }
}
