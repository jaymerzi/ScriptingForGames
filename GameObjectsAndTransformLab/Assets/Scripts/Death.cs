using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Death : MonoBehaviour
{
    public SimpleFloatData health;
    private AudioSource audioSource;
    public UnityEvent triggerEvent;

    // Start is called before the first frame update
    void Start()
    {
        health.value = 1f;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health.value <= 0f)
        {
            PlayerDied();
        }
    }

    private void PlayerDied()
    {
        LevelManager.instance.GameOver();
        gameObject.SetActive(false);
        triggerEvent.Invoke();
    }
}
