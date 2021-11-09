using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Configscript : MonoBehaviour
{
    [SerializeField] Slider volumenSlider;
    // Start is called before the first frame update
    void Start()
    {
        volumenSlider.value = GameManager.volumeMusic;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Cambiarvolumenmusica()
    {
        GameManager.volumeMusic = volumenSlider.value;
    }
}
