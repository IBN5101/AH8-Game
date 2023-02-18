using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterU : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Player>(out Player player))
        {
            player.AddForce(Vector2.up, 100);
        }
    }
}
