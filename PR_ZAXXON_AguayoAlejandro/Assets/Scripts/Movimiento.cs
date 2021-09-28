using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    bool vivo = true;
    bool invencible = false;
    float speed = 10f;
   
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float DesplY = Input.GetAxis("Vertival") * speed;
        transform.Translate(Vector).up * DesplY * Time.deltaTime;

        float DesplX = Input.GetAxis("Horizontal") * speed;
        transform.Translate(Vector).up * DesplY * Time.deltaTime;


    }
}
