using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanPlanetas : MonoBehaviour
{

    [SerializeField] GameObject prefab;
    [SerializeField] GameObject prefab2;
    [SerializeField] float distanciaentreobtaculos;
    [SerializeField] InitGame initGame;
    [SerializeField] GameObject[] Obstaculos;
    float speed;
    float limiteL = -100f;
    float limiteR = 100f;
    float limiteAb = 100f;
    float limiteAr = 100f;
    float randomY;
    float intervalo;
    //float Highscores;
    [SerializeField] Transform instantiatePos;
    // Start is called before the first frame update
    void Start()
    {

        initGame = GameObject.Find("InitGame").GetComponent<InitGame>();

        distanciaentreobtaculos = 50f;



        StartCoroutine("Obstaculo");

    }
    void Update()
    {

    }
    IEnumerator Obstaculo()
    {

        while (true)
        {

            speed = initGame.spaceshipSpeed;
            intervalo = distanciaentreobtaculos / initGame.spaceshipSpeed;
            int numAl = Random.Range(0, Obstaculos.Length);

            float randomX;
            if (Obstaculos[numAl].tag != "Planetas")
            {
                randomX = Random.Range(limiteL, limiteR);
                randomY = Random.Range(limiteAr, limiteAb);
            }
            else
            {
                randomX = 0f;
            }

            Vector3 newPos = new Vector3(randomX, instantiatePos.position.y + randomY, instantiatePos.position.z + randomY);

            Instantiate(Obstaculos[numAl], newPos, Quaternion.identity);


            yield return new WaitForSeconds(intervalo);
        }
    }
}
