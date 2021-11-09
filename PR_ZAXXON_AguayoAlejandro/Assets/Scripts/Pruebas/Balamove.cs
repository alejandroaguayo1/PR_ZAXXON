using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balamove : MonoBehaviour
{
    [SerializeField] float balistica;
    // Start is called before the first frame update
    void Start()
    {
        balistica = 1f; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * balistica);
        float posZ = transform.position.z;
        if(posZ >= 50f)
        {
            Destroy(gameObject);
        }
    }
}
