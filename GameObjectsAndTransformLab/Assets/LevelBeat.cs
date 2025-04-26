using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBeat : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            LevelManager.instance.LevelClear();
        }
    }
}
