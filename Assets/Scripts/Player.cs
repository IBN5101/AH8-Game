using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveMultiplier = 5;
    [SerializeField] private float jumpMultiplier = 5;

    private Rigidbody2D rigidbody2d;
    private Vector2 moveDir;
    private bool jumpAllowed;
    private bool jumpPhysics;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        moveDir = Vector2.zero;
        if (Input.GetKey(KeyCode.A))
        {
            moveDir += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDir += Vector2.right;
        }
        if (Input.GetKeyDown(KeyCode.W) && jumpAllowed)
        {
            jumpAllowed = false;
            jumpPhysics = true;
        }
    }

    private void FixedUpdate()
    {
        // Horizontal movement
        rigidbody2d.AddForce(moveDir * moveMultiplier, ForceMode2D.Impulse);

        // Vertical movement
        if (jumpPhysics)
        {
            rigidbody2d.AddForce(Vector2.up * jumpMultiplier, ForceMode2D.Impulse);
            jumpPhysics = false;
        }
        // Allow jumping again if vertical velocity is near 0.
        // Note that this may allows jumping at midair.
        if (!jumpAllowed && Math.Abs(rigidbody2d.velocity.y) < 0.01f)
        {
            jumpAllowed = true;
        }
    }

    public void AddForce(Vector2 direction, float forceMulti)
    {
        rigidbody2d.AddForce(direction * forceMulti, ForceMode2D.Impulse);
    }
}
