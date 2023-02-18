using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    private float timer = 0f;
    private float timerMax = 3f;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > timerMax)
        {
            Destroy(gameObject);
        }
    }
}
