using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energie : MonoBehaviour
{
    [SerializeField] Slider Energ�a;
    InitGame initGame;
    int n;
    
     
    // Start is called before the first frame update
    void Start()
    {
        initGame = GameObject.Find("InitGame").GetComponent<InitGame>();

        Energ�a.value = 0;
        initGame.cargada = false;
        initGame.invencible = false;

    }

    // Update is called once per frame
    void Update()
    {

        Turbo();

    }
    public void Turbo()
    {
        if (initGame.cargada == false)
        {
            Energ�a.value += 10f * Time.deltaTime;
            if (Energ�a.value >= 100f)
            {
                initGame.cargada = true;
            }
        }
        if (Input.GetKeyDown("space") && initGame.cargada == true)
        {
            Energ�a.value -= 50f;
            initGame.spaceshipSpeed = 10f + n++ * Time.deltaTime;
            initGame.invencible = true;
            
            initGame.cargada = false;
        }
        if (initGame.invencible == true)
        {
            initGame.alive = true;
            
        }
    }
}
