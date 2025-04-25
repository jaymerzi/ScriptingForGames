using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public SimpleFloatData health;

    // Start is called before the first frame update
    void Start()
    {
        health.value = 1f;
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
    }
}
