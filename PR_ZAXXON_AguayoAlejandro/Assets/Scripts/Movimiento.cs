using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

  
    float speedH = 10f;
    float speedV = 10f;
    float despspeed = 10f;
    float limeteR = -10f;
    float limeteL = 10f;
    float limeteU = 10f;
    float limeteS = 1f;

    // Start is called before the first frame update
    void Start()
    {
        despspeed = 10f;                                                                                                                       
    }

    // Update is called once per frame
    void Update()
    {
        float desplH = Input.GetAxis("Horizontal");
        float desplV = Input.GetAxis("Vertical");
        float posX = transform.position.x;
        float posY = transform.position.y;
        float rot = Input.GetAxis("Horizontal-J2");
        if (posX > limeteR && desplH > 0)
        {
            despspeed = 0f;

        }
        else
        {
            despspeed = 10f;
        }
        float DesplH = Input.GetAxis("Vertival") * speedH;
        transform.Translate(Vector3.up * DesplH * Time.deltaTime);

        float DesplV = Input.GetAxis("Horizontal") * speedV;
        transform.Translate(Vector3.right * DesplV * Time.deltaTime);

        if (posX > limeteL && desplV > 0)
        {
            despspeed = 0f;

        }
        else
        {
            despspeed = 10f;
        }

        

    }
}
