using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InitGame : MonoBehaviour
{
    public float spaceshipSpeed = 0f;
    // saber en qué escena estoy int y = SceneManager.GetActiveScene()BuildIndex; 

    //float n = 0f;
    static float score;
    //velocidad max
    [SerializeField] float maxSpeed;
    public bool  alive;

    //UI
    [SerializeField] Text scoreText;
    [SerializeField] Text speedText;
    // Start is called before the first frame update
    void Start()
    {
        spaceshipSpeed = 10f;

        //score = 0; //distancia recorrida = velocidad * tiempo (con el time)
        maxSpeed = 70;
        alive = true;
        //float tiempopasado = Time.time;
        scoreText.text = (Mathf.Round(score)) + "mts";

    }

    // Update is called once per frame
    void Update()
    {
        if(spaceshipSpeed < maxSpeed && alive == true)
        {

            spaceshipSpeed += 0.001f;

        }

        //posible turbo spaceshipSpeed = 10f + n++ * Time.deltaTime; 

        float tiempo = Time.time; //-tiempopasado (posibilidades)
        //print(Mathf.Round(tiempo));
        score = Mathf.Round(tiempo) * spaceshipSpeed;
        //print(Mathf.Round(score));
        scoreText.text = (Mathf.Round(score)) + "mts";
        float speedMetric = (spaceshipSpeed * 3600) / 1000;
        speedText.text = (Mathf.Round(speedMetric)) + "km/h";
    }
    // void Morir mirar GitHub

    public void Pararobst()
    {
        StopCoroutine("Obstaculo");

    }
    public void Morir()
    {
        print("Me he muerto");
        alive = false;
        spaceshipSpeed = 0f;
        Instanciadorobst instanciadorobst = GameObject.Find("Instanciador").GetComponent<Instanciadorobst>();
        instanciadorobst.SendMessage("Pararobst");
        //SceneManager.LoadScene(2);
    }


}
