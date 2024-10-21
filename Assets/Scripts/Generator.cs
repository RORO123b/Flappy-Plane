using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public Rigidbody2D obstacol1;
    public Rigidbody2D obstacol2;

    public int spawn_interval = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(generare());
    }

    IEnumerator generare()
    {
        while(true)
        {
            Spawn();
            yield return new WaitForSeconds(spawn_interval);
        }
    }

    void Spawn()
    {
        float y = Random.Range(-8.5f,-2.8f);
        Rigidbody2D newobstacle1 = Instantiate(obstacol1);
        newobstacle1.transform.position = new Vector3(11, y);
        Rigidbody2D newobstacle2 = Instantiate(obstacol2);
        newobstacle2.transform.position = new Vector3(11, y+12);
        Destroy(newobstacle1.gameObject, 6f);
        Destroy(newobstacle2.gameObject, 6f);
    }
}
