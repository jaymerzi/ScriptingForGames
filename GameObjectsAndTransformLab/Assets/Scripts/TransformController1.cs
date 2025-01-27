using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController1 : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    private void Update()
    {
        var x = Mathf.PingPong(Time.time, 1);
        var p = new Vector3(x, x, 0);
        transform.position = p;

        transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime);

    }
}
