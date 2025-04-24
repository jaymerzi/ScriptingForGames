using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCameraBehaviour : MonoBehaviour
{

    public float CamHeight = -5f;
    private Transform thisTransform;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void KeepCharacterOnYAxis()
    {
        var currentPosition = thisTransform.position;
        currentPosition.y = CamHeight;
        thisTransform.position = currentPosition;
    }
}
