using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Configscript : MonoBehaviour
{
    [SerializeField] Slider volumenSlider;
    [SerializeField] Slider dificultadSlider;
    [SerializeField] Slider musicaSlider;


    // Start is called before the first frame update
    void Start()
    {
        volumenSlider.value = GameManager.volumeMusic;
        dificultadSlider.value = GameManager.dificultad;
        musicaSlider.value = GameManager.música;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Cambiarvolumenmusica()
    {
        GameManager.volumeMusic = volumenSlider.value;
        GameManager.dificultad = dificultadSlider.value;
        GameManager.música = musicaSlider.value;


    }
    public void EscenaVolverInicio()
    {
        SceneManager.LoadScene(0);

    }
    public void EscenaVolverJuego()
    {
        SceneManager.LoadScene(1);

    }
}
