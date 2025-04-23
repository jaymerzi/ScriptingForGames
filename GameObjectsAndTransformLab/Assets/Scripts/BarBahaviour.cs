using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarBehaviour : MonoBehaviour
{

public float maxHealth = 1f;

private float health;

private RectTransform HealthBar;

public SimpleFloatData dataObj;

 private void Update()
    {
        GameObject healthBar = this.gameObject;
        health = (dataObj.value / maxHealth) * 100f;
        var healthBarRectTransform = healthBar.transform as RectTransform;
        healthBarRectTransform.sizeDelta = new Vector2(health, healthBarRectTransform.sizeDelta.y);
    }
}
