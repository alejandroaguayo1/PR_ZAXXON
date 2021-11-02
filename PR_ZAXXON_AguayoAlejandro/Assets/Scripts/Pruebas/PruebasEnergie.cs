using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energie : MonoBehaviour
{
    [SerializeField] Slider Energía;
    // Start is called before the first frame update
    void Start()
    {
        Energía.value = 100;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Energía.value -= 10f;
        }


    }
}
