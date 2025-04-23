using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapImpactAnim : MonoBehaviour
{
    public float growFactor = 1.8f;

    // Start is called before the first frame update
    public void Impact()
    {
        StartCoroutine(test());
    }
    IEnumerator test()
    {
        transform.localScale *= growFactor;
        yield return new WaitForSeconds(0.1f);
        transform.localScale /= growFactor;
    }
        /*transform.localScale *= growFactor;
        yield return new WaitForSeconds(0.3);
        transform.localScale /= growFactor;*/

}
