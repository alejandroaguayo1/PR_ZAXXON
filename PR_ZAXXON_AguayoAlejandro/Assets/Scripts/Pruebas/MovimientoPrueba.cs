using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPrueba : MonoBehaviour
{
    float despspeed = 10f;
    float limeteR = -10f;
    float limeteL = 10f;
    float limeteU = 10f;
    float limeteS = 1f;

    bool inLimitH = true;
    bool inLimitV = true;
    bool inLimitR = true;
    bool inLimitL = true;

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
        

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up * Time.deltaTime * despspeed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down * Time.deltaTime * despspeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * despspeed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * despspeed);
        }
        if (posX > limeteR && desplH > 0 || posX < limeteL && desplH < 0)
        {
            inLimitH = false;

        }

        else
        {
            inLimitH = true;
        }

        if (inLimitH)
        {
            transform.Translate(Vector3.down * Time.deltaTime * desplV * despspeed, Space.World);
        }


        if (inLimitV)
        {
            transform.Translate(Vector3.up * Time.deltaTime * desplV * despspeed, Space.World);
        }

        if (inLimitL)
        {
            transform.Translate(Vector3.left * Time.deltaTime * desplH * despspeed, Space.World);
        }

        if (inLimitR)
        {
            transform.Translate(Vector3.right * Time.deltaTime * desplH * despspeed, Space.World);
        }
    }
}
