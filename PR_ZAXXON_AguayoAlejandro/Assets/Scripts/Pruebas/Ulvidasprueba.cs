using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ulvidasprueba : MonoBehaviour
{
    [SerializeField] Image lives;
    [SerializeField] Sprite[] livesArray;
    [SerializeField] int vidas;
    int spritesPos = 0;
    [SerializeField] InitGame initGame;

    // Start is called before the first frame update
    void Start()
    {
        vidas = livesArray.Length; //mejor crearlas en el menu inicial
        lives.sprite = livesArray[spritesPos];//recodar expotar sprites como highsprites
        initGame = GameObject.Find("InitGame").GetComponent<InitGame>();
    }

    // Update is called once per frame
    void Update()
    {
        if (initGame.alive == false)
        {
            //lives.sprite = spritelives2;
            //Chocar();
        }

        

    }

    
}
