using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebaobst : MonoBehaviour
{

    [SerializeField] GameObject initObject;
    InitGameScript initGameScript;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        initObject = GameObject.Find("InitGame");

        initGameScript = initObject.GetComponent<InitGameScript>();

        
    }

    // Update is called once per frame
    void Update()
    {
        speed = initGameScript.spaceshipSpeed;
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
