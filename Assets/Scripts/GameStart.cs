using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField] private GameObject startCage;

    private float timer = 0f;
    private float timerMax = 1.5f;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > timerMax)
        {
            Activate();
        }
    }

    private void Activate()
    {
        Destroy(startCage);
        Destroy(gameObject);
    }
}
