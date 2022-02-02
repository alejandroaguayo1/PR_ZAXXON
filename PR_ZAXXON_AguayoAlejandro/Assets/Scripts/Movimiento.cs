using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movimiento : MonoBehaviour
{
    InitGame initGame;
    

    [SerializeField] float desplSpeed;
    //[SerializeField] GameObject navePrefab;
    //[SerializeField] Transform cannon;
    
    float limiteR = 10;
    float limiteL = -10;
    float limiteU = 15;
    float limiteS = 3f;

    
    bool inLimitH = true;
    bool inLimitV = true;

    

    // Start is called before the first frame update
    void Start()
    {
        initGame = GameObject.Find("InitGame").GetComponent<InitGame>();
        transform.position = new Vector3(0f, 2.3f, 0f);
        
        desplSpeed = initGame.spaceshipSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Girar();
        MoverNave();
       
        /*if (Input.GetButtonDown("Fire1"))
        {
            Disparar();
        }*/
    }
    /*void Disparar()
    {
        Instantiate(bola, cannon);
    }*/

    void MoverNave()
    {
        
        float desplH = Input.GetAxis("Horizontal");
        float desplV = Input.GetAxis("Vertical");


       
        float posX = transform.position.x;
        float posY = transform.position.y;

        
        if (posX > limiteR && desplH > 0 || posX < limiteL && desplH < 0)
        {
            inLimitH = false;
        }
        else
        {
            inLimitH = true;
        }

        if (posY > limiteU && desplV > 0 || posY < limiteS && desplV < 0)
        {
            inLimitV = false;
        }
        else
        {
            inLimitV = true;
        }

        if (inLimitH)
        {
            transform.Translate(Vector3.right * Time.deltaTime * desplH * desplSpeed, Space.World);
        }


        if (inLimitV)
        {
            transform.Translate(Vector3.up * Time.deltaTime * desplV * desplSpeed, Space.World);
        }
        
    }

    void Girar()
    {
        float rot = Input.GetAxis("Horizontal-J2");
        transform.Rotate(Vector3.back * Time.deltaTime * rot * 100f);
    }
    
    
    
    private void OnTriggerEnter(Collider other)
    {
      
        //if (initGame.invencible == false)
                if (other.gameObject.layer == 6)
        {
            
            initGame.SendMessage("Morir");
            //navePrefab.SetActive(false);
            
        }
        /*
        if(initGame.invencible == true)
        {
            initGame.alive = true;
        }
        */
    }
}
