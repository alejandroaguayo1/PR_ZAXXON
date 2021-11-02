using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaMovTerreno : MonoBehaviour
{
    float speed;
    InitGame initGame;

    [SerializeField] GameObject terrenoPrefab;
    Vector3 instPos = new Vector3(0f, 0f, 100f);


    // Start is called before the first frame update
    void Start()
    {
        initGame = GameObject.Find("InitGame").GetComponent<InitGame>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = initGame.spaceshipSpeed;
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        if (transform.position.z <= -100)
        {
            Instantiate(terrenoPrefab, instPos, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
