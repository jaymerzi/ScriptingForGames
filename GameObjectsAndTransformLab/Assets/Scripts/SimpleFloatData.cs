using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SingleVariables/ SimpleFloatData")]
public class SimpleFloatData : ScriptableObject
{
   public float value;

   public void Begin(float amount)
   {
      value = amount;
   }

   public void AddValue(float amount)
   {
      value += amount;
   }

   public void SubtractValue(float amount)
   {
      value -= amount;
   }

   public void SetValue(float amount)
   {
      value = amount;
   }
}