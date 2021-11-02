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

    // Start is called before the first frame update
    void Start()
    {
        vidas = livesArray.Length; //mejor crearlas en el menu inicial
        lives.sprite = livesArray[spritesPos];//recodar expotar sprites como highsprites
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //lives.sprite = spritelives2;
            Chocar();
        }

        

    }

    public void Chocar()
    {
        //lives.sprite = lives;
        vidas--;
        if(vidas > 0)
        {
            spritesPos++;
            lives.sprite = livesArray[spritesPos];
        }
        else
        {
            print("muerte");
        }
    }
}
