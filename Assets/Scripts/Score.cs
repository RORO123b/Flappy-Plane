using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float s = 0;
    public float highscore = 0;

    public Text score_text;
    public Text highscore_text;
    void Start()
    {
        s = 0;
        highscore = PlayerPrefs.GetFloat("Highscore");
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = "Score: " + s.ToString();
        if (highscore < s)
        {
            highscore = s;
            PlayerPrefs.SetFloat("Highscore", highscore);
        }
        highscore_text.text = "Highscore: " + highscore.ToString();
    }
}
