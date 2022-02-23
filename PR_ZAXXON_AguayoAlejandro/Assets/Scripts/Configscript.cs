using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Configscript : MonoBehaviour
{
    [SerializeField] Slider volumenSlider;
    [SerializeField] Slider efectosSlider;
    [SerializeField] Slider musicaSlider;
    [SerializeField] AudioMixer audioMixer;


    // Start is called before the first frame update
    void Start()
    {
        volumenSlider.value = GameManager.volumeMusic;
        efectosSlider.value = GameManager.efectos;
        musicaSlider.value = GameManager.música;


    }

    // Update is called once per frame
    void Update()
    {
        Cambiarvolumenmusica();
        volumenSlider.onValueChanged.AddListener(delegate { SetSound("Master", volumenSlider.value); });
    }
    public void Cambiarvolumenmusica()
    {
        GameManager.volumeMusic = volumenSlider.value;
        GameManager.efectos = efectosSlider.value;
        GameManager.música = musicaSlider.value;


    }
    public void SetSound(string tipoVolumen, float nivelVol)
    {
        audioMixer.SetFloat(tipoVolumen, nivelVol);
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
