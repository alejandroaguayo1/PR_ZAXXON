using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    bool vivo = true;
    bool invencible = false;
    float speedH = 10f;
    float speedV = 10f;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float DesplY = Input.GetAxis("Vertival") * speedH;
        transform.Translate(Vector3.up * DesplY * Time.deltaTime);

        float DesplX = Input.GetAxis("Horizontal") * speedV;
        transform.Translate(Vector3.down * DesplX * Time.deltaTime);


    }
}
