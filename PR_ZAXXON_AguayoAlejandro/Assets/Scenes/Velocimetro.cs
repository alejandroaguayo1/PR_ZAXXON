using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocimetro : MonoBehaviour
{

    bool moving = true;
    float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 0f, 0f);
    }
    
    // Update is called once per frame
    void Update()
    {
        float tiempotranscurrido = Time.time;
        if (moving)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if(tiempotranscurrido >= 10)
        {
            moving = false;
            float posZ = transform.position.z / 10;
            print("te mueves a una velocidad de" + posZ);
        }   
        //print(Time.time);

    }
}
