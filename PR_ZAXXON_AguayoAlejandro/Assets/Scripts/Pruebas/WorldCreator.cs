using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCreator : MonoBehaviour
{


    [SerializeField] GameObject Ladrillo;
    [SerializeField] Transform InitPos;
    float separacion;


    // Start is called before the first frame update
    void Start()
    {
        separacion = 1f;
        Vector3 newPos = InitPos.position;
        Vector3 despl = new Vector3(separacion, 0f, 0f);
        

        for(int n=0; n < 10; n++)
        {

            Instantiate(Ladrillo, newPos,Quaternion.identity);
            newPos = newPos + despl;
            
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
