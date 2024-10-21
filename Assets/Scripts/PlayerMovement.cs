using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float jump=10f;

    [SerializeField] AudioSource jumpSF;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpSF.Play();
            rb.AddForce(Vector2.up * jump);
        }
        if(rb.velocity.y>0)
            transform.rotation = Quaternion.Euler(0, 0, 40);
        else
            transform.rotation = Quaternion.Euler(0, 0, -40);

    }
}
