using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Transform tr;

    [SerializeField] float speed;

    private void Awake()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(-speed * Time.deltaTime, 0);
    }
    private void Update()
    {
        if (tr.position.x < -21)
            tr.SetPositionAndRotation(new Vector3(21,0,0),Quaternion.identity);
    }
}
