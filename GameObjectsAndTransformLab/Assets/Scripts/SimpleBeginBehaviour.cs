using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleBeginBehaviour : MonoBehaviour
{
    public UnityEvent triggerEvent;

    private void Start()
    {
        triggerEvent.Invoke();
    }
}