using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energie : MonoBehaviour
{
    [SerializeField] Slider Energ�a;
    // Start is called before the first frame update
    void Start()
    {
        Energ�a.value = 100;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Energ�a.value -= 10f;
        }


    }
}
