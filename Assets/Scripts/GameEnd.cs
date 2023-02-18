using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    [SerializeField] private List<GameObject> squares;

    private float timer;
    private float timerInterval = 0.02f;

    private int iteration = 0;

    private bool execute = true;

    private void Update()
    {
        if (execute)
        {
            timer += Time.deltaTime;
            while (timer > timerInterval)
            {
                timer -= timerInterval;
                squares[iteration].SetActive(true);

                iteration++;

                if (iteration >= squares.Count)
                {
                    Debug.Log("COMPLETE!");
                    execute = false;
                }
            }
        }
        
    }
}
