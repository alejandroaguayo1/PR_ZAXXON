using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScores : MonoBehaviour
{
    [SerializeField] Text Highscore;
    // Start is called before the first frame update
    void Start()
    {
        Highscore.text = "HighScore: " + (Mathf.Round(GameManager.Highscores)) + "Pts";
    }
    public void EscenaVolverJuego()
    {
        SceneManager.LoadScene(1);

    }
    public void EscenaVolverInicio()
    {
        SceneManager.LoadScene(0);

    }


}
