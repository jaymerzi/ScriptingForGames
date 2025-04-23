using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SingleVariables/ SimpleFloatData")]
public class SimpleFloatData : ScriptableObject
{
   public float value;

   public void Begin(float amount)
   {
      value = 1f;
   }

   public void AddValue(float amount)
   {
      if (value < 1f)
      {
         value += amount;
      }
   }

   public void SubtractValue(float amount)
   {
      if (value > 0f)
      {
         value -= amount;
      }
   }

   public void SetValue(float amount)
   {
      value = amount;
   }
}