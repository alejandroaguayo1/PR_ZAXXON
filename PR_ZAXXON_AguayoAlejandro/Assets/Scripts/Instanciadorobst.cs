using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciadorobst : MonoBehaviour
{

    [SerializeField] GameObject prefab;
    [SerializeField] GameObject prefab2;
    [SerializeField] float distanciaentreobtaculos;
    [SerializeField] InitGame initGame;

    float intervalo;
    // Start is called before the first frame update
    void Start()
    {
        
        initGame = GameObject.Find("InitGame").GetComponent<InitGame>();
        //intervalo = 0.4f;
        distanciaentreobtaculos = 4f;
        
        
        StartCoroutine("Obstaculo");

    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator Obstaculo()
    {
        intervalo = distanciaentreobtaculos / initGame.spaceshipSpeed;
        
        for (int n = 0; ; n++) 
        { 
            float aleatorioX = Random.Range(-9, 10);
            float aleatorioY = Random.Range(0, 5);
            Vector3 newPos = new Vector3(aleatorioX, aleatorioY, transform.position.z);
            int RandomNum = Random.Range(0, 2);
            if (RandomNum == 0)
            {
                Instantiate(prefab, newPos, Quaternion.identity);  
                
            }
            else if (RandomNum == 1)
            {
                Instantiate(prefab2, newPos, Quaternion.identity);

            }
            yield return new WaitForSeconds(intervalo);
        }


        /* for (int n = 0; ; n++)
        {
            float aleatorioX = Random.Range(-9, 10);
            float aleatorioY = Random.Range(0, 15);
            Vector3 newPos = new Vector3(aleatorioX, aleatorioY, transform.position.z);
            Instantiate(prefab, newPos, Quaternion.identity);
            yield return new WaitForSeconds(intervalo);

        }*/



    }
    public void Pararobst() 
    {
        StopCoroutine("Obstaculo");
    
    }
}
