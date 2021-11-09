using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour
{
    [SerializeField] Text Highscore;
    // Start is called before the first frame update
    void Start()
    {
        Highscore.text = "HighScore: " + GameManager.Highscores + "Pts";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
