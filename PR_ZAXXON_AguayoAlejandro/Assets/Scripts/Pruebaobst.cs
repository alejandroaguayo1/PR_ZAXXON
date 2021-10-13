using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebaobst : MonoBehaviour
{

    [SerializeField] GameObject prefab;
    [SerializeField] float distanciaentreobtaculos;
    InitGameScript initGameScript;
    float intervalo;
    // Start is called before the first frame update
    void Start()
    {
        initGameScript = GameObject.Find("InitGame").GetComponent<InitGameScript>();
        intervalo = 0.4f;
        distanciaentreobtaculos = 30f;
        StartCoroutine("Obstaculo");

    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator Obstaculo()
    {


        for (int n = 0; ; n++)
        {
            float aleatorioX = Random.Range(-9, 10);
            float aleatorioY = Random.Range(0, 5);
            Vector3 newPos = new Vector3(aleatorioX, aleatorioY, transform.position.z);
            Instantiate(prefab, newPos, Quaternion.identity);
            yield return new WaitForSeconds(intervalo);

        }



    }
}
