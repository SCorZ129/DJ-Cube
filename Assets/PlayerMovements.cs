using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Rigidbody rb;
    public BoxCollider bx;

    public float Movespeed = 5;
    private void Start()
    {
        transform.position = new Vector3(0, 1f, 8.5f);
    }

    private void Update()
    {
        float DirectX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(DirectX * Movespeed, rb.velocity.y);

    }
}
