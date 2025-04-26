using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SingleVariables/ SimpleBoolData")]
public class SimpleBoolData : ScriptableObject
{
    public bool value;

    public void Begin()
    {
      value = false;
    }

    public void makeTrue()
    {
        value =  true;
    }

    public void makeFalse()
    {
        value =  false;
    }
}
