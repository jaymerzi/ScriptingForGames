using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController2 : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    private void Update()
    {
        var x = Mathf.PingPong(Time.time, 4);
        var p = new Vector3(3, 0, x);
        transform.position = p;

        transform.Rotate(new Vector3(10, 5, 30) * Time.deltaTime);

    }
}
