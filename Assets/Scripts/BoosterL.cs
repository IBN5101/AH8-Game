using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterL : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Player>(out Player player))
        {
            player.AddForce(Vector2.left, 50);
        }
    }
}
