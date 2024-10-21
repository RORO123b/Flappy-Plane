using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacol"))
        {
            MusicScript.instance.GetComponent<AudioSource>().Pause();
            SceneManager.LoadScene("Death Screen");
        }
    }
}
