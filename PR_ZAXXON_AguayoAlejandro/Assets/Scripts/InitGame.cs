using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        spaceshipSpeed = 10f;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * desplSpeed);
        float posZ = transform.position.z;
        if (posZ < -1) 
        {

            Destroy(Player);

        }
            

    }
}
