using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public void destroyObject()
    {
        Destroy(gameObject, 0.6f);
    }
}
