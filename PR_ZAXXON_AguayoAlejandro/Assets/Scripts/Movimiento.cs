using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movimiento : MonoBehaviour
{
    InitGame initGame;
    

    [SerializeField] float desplSpeed;
    [SerializeField] GameObject navePrefab;
    
    float limiteR = 10;
    float limiteL = -10;
    float limiteU = 10;
    float limiteS = 1;

    
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
        MoverNave();
        float rot = Input.GetAxis("Horizontal-J2");
        transform.Rotate(Vector3.back * Time.deltaTime * rot * 100f);
    }

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
    /*private void OnTriggerEnter(Collider other)    destruir nave
    {
        if(other.gameObject.layer ==//numero capa de obstaculos)
            
        {
            iniGameScript.spaceshiSpeed= 0f;
            Destroy(other.gameObject);

        }*/
    private void OnTriggerEnter(Collider other)
    {
        print("boom");
        if (other.gameObject.layer == 6)
        {

            //initGameScript.SendMessage("Morir");
            navePrefab.SetActive(false);
            //Destroy(gameObject);

        }
    }
}
