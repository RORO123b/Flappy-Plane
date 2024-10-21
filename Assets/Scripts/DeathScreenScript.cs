using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void StartButton()
    {
        MusicScript.instance.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("PreGame");
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
