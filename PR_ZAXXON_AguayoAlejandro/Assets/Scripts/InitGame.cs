using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{
    public float spaceshipSpeed = 0f;
    float n = 0f;
    // Start is called before the first frame update
    void Start()
    {
        spaceshipSpeed = 10f;

    }

    // Update is called once per frame
    void Update()
    {
        
        spaceshipSpeed = 10f + n++ * Time.deltaTime;



    }
}
