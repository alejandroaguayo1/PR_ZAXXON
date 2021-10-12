using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebaobst : MonoBehaviour
{

    [SerializeField] GameObject Initgame;


    // Start is called before the first frame update
    void Start()
    {
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
            float aleatorioY = Random.Range(-5, 6);
            Vector3 newPos = new Vector3(aleatorioX, aleatorioY, transform.position.z);
            Instantiate(Initgame, newPos, Quaternion.identity);
            yield return new WaitForSeconds(0.1f);

        }



    }
}
