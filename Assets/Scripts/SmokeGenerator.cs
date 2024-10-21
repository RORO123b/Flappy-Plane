using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeGenerator : MonoBehaviour
{
    public Rigidbody2D smoke;

    public int spawn_interval2 = 3;

    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Generare());
    }

    IEnumerator Generare()
    {
        while (true)
        {
            spawn();
            yield return new WaitForSeconds(spawn_interval2);
        }
    }

    void spawn()
    {
        Rigidbody2D newsmoke = Instantiate(smoke);
        newsmoke.position = new Vector2(player.position.x - 0.2f, player.position.y);
        Destroy(newsmoke.gameObject, 6f);
    }
}
