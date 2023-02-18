using UnityEngine;

public class GameStart : MonoBehaviour
{
    private float timer = 0f;
    private float timerEvent1 = 1f;
    private float timerEvent2 = 2f;
    private bool event1 = true;
    private bool event2 = true;

    private void Update()
    {
        timer += Time.deltaTime;
        if (event1 && timer > timerEvent1)
        {
            // Note: This is not the best idea.
            // This should have been a separate function, but lazy.
            LevelController.Instance.LevelCleared(0);
        }
        if (event2 && timer > timerEvent2)
        {
            Destroy(gameObject);
        }
    }
}
