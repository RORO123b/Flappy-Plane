using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    Rigidbody2D rb;

    Transform tr;

    bool ok = false;

    [SerializeField] float speed = 100f;

    [SerializeField] AudioSource collectSF;

    public Score sc;

    private void Awake()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        sc = GameObject.FindObjectOfType<Score>();
    }

    private void Update()
    {
        if (tr.position.x <= -5.5 && ok == false)
        {
            collectSF.Play();
            sc.s+=1f;
            ok = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity=new Vector2(-speed*Time.deltaTime,0);
    }
}
