using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartButton()
    {
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
