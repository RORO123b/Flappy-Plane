using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeMovement : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float speed = 100f;

    public Score sc;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(-speed * Time.deltaTime, 0);
    }
}
