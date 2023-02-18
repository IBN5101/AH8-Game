using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    [SerializeField] private List<GameObject> squares;

    private float timer;
    private float timerInterval = 0.02f;
    private float timerFinal = 2f;

    private int iteration = 0;

    private bool execute = true;

    private void Update()
    {
        timer += Time.deltaTime;
        if (execute)
        {
            while (timer > timerInterval)
            {
                timer -= timerInterval;
                squares[iteration].SetActive(true);

                iteration++;

                if (iteration >= squares.Count)
                    execute = false;
            }
        }
        else
        {
            if (timer > timerFinal)
            {
                // Reload the current scene
                SceneManager.LoadScene("Main");
            }
        }
        
    }
}
