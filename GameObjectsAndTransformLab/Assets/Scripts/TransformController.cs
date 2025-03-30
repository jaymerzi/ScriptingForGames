using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    private void Update()
    {
        var x = Mathf.PingPong(Time.time, 10);
        var p = new Vector3(-3, x, 0);
        transform.position = p;

        transform.Rotate(new Vector3(0, 200, 0) * Time.deltaTime);
    }
}
