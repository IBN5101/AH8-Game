using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private int goalLevel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LevelController.Instance.LevelCleared(goalLevel);
        Instantiate(LevelController.Instance.completedGoal, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
