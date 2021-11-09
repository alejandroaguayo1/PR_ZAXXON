using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pruebascambiomenu : MonoBehaviour
{
    [SerializeField] int escena;


      public void Cambiodeescena()
    {
        SceneManager.LoadScene(escena);

    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene(1);
    }

    public void EscenaConfig()
    {
        SceneManager.LoadScene(2);

    }
    public void EscenaHighScores()
    {
        SceneManager.LoadScene(4);

    }
}
