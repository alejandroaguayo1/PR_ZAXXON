using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InitGame : MonoBehaviour
{
    public float spaceshipSpeed = 0f;
    // saber en qué escena estoy int y = SceneManager.GetActiveScene()BuildIndex; 

   
    public float score;
    [SerializeField] float maxSpeed;
    public bool  alive;
    public bool invencible;
    public bool cargada;
    public float duracioninv = 2f;

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

        float tiempo = Time.timeSinceLevelLoad;
        score = Mathf.Round(tiempo) * spaceshipSpeed;
        scoreText.text = (Mathf.Round(score)) + "mts";
        float speedMetric = (spaceshipSpeed * 3600) / 1000;
        speedText.text = (Mathf.Round(speedMetric)) + "km/h";
    }

    public void Pararobst()
    {
        StopCoroutine("Obstaculo");

    }
    public void Morir()
    {
        alive = false;
        spaceshipSpeed = 0f;
        Instanciadorobst instanciadorobst = GameObject.Find("Instanciador").GetComponent<Instanciadorobst>();
        instanciadorobst.SendMessage("Pararobst");
        GameObject.Find("Navegrupo").SetActive(false);
        Invoke("GameOver", 1f);
        if (score > GameManager.Highscores)
        {
            GameManager.Highscores = score;
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(3);
    }
    public void Invencibilidad()
    {
        alive = true;
        Invoke("PararInv", duracioninv);

    }

    public void PararInv()
    {

    }



}
