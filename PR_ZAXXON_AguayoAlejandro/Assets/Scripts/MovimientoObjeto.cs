using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoObjeto : MonoBehaviour
{   InitGame initGame; 

    // Start is called before the first frame update
    void Start()
    {
        initGame = GameObject.Find("InitGame").GetComponent<InitGame>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * initGame.spaceshipSpeed);
        float posZ = transform.position.z;
         if (posZ < -8) 
         {

             Destroy(gameObject);

         }
    }
}
