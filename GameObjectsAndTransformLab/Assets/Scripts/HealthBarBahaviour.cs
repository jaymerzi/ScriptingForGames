using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehaviour : MonoBehaviour
{

public float maxHealth = 1f;

private float health;

private RectTransform HealthBar;

public SimpleFloatData dataObj;

 private void Update()
    {
        GameObject healthBar = GameObject.Find ("Canvas/Health/HealthBar");
        health = (dataObj.value / maxHealth) * 100f;
        var healthBarRectTransform = healthBar.transform as RectTransform;
        healthBarRectTransform.sizeDelta = new Vector2(health, healthBarRectTransform.sizeDelta.y);
        //SetWidth();
    }

/*void SetWidth()
{
    healthBarRectTransform = new Vector2 (50f, 50f);
}

/*
public float Health, MaxHealth, Width, Height;

public SimpleFloatData dataObj;

[SerializeField]
private RectTransform HealthBar;

public void SetMaxHealth(float maxHealth)
{
    MaxHealth = maxHealth;
}

public void ChangeSliderValue(float health)
{
    Health = health;
    float newWidth = (Health / MaxHealth) * Width;

    HealthBar.sizeDelta = new Vector2(newWidth, Height);
}

/*
    public float Health, MaxHealth, Width, Height

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
