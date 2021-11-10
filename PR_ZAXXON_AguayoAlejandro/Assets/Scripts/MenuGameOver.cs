using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    public void EscenaVolverJuego()
    {
        SceneManager.LoadScene(1);

    }
    public void EscenaVolverInicio()
    {
        SceneManager.LoadScene(0);

    }
}
