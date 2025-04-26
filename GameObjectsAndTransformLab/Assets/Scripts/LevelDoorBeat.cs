using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelDoorBeat : MonoBehaviour
{
    [SerializeField]
    public SimpleBoolData keyGotten;
    public bool keyCheck;
    public UnityEvent triggerEvent;

    void Update()
    {
        keyCheck = keyGotten.value;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            if (keyCheck)
            {
                LevelManager.instance.LevelClear();
                triggerEvent.Invoke();
            }
        }
    }
}
