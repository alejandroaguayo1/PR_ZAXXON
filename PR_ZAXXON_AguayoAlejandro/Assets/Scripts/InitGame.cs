using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InitGame : MonoBehaviour
{
    public float spaceshipSpeed = 0f;         
    public float score;
    [SerializeField] float maxSpeed;
    public bool  alive;    
    public bool cargada;
    public float duracioninv = 2f;

    //Particulas
    [SerializeField] GameObject Explosion;
    [SerializeField] Transform PosiNave;

    //Audio
    AudioSource audioSource;
    [SerializeField] AudioClip explosion;
    
    //Vidas
    [SerializeField] Image lives;
    [SerializeField] Sprite[] livesArray;
    [SerializeField] int vidas;
    int spritesPos = 0;
    [SerializeField] InitGame initGame;

    //UI
    [SerializeField] Text scoreText;
    [SerializeField] Text speedText;
    
    // Start is called before the first frame update
    void Start()
    {
        spaceshipSpeed = 10f;
        vidas = 3;
        lives.sprite = livesArray[spritesPos];
       
        maxSpeed = 70;
        alive = true;
        audioSource = GetComponent<AudioSource>();
        
        scoreText.text = (Mathf.Round(score)) + "mts";
        

    }

    // Update is called once per frame
    void Update()
    {
        if(spaceshipSpeed < maxSpeed && alive == true)
        {

            spaceshipSpeed += 0.001f;

        }

         

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
        Vector3 posNave = new Vector3(PosiNave.position.x, PosiNave.position.y, PosiNave.position.z);
        GameObject ExplosionClone = Instantiate(Explosion, posNave, Quaternion.identity) as GameObject;
        Destroy(ExplosionClone, 1f);
        Invoke("GameOver", 1.2f);
        if (score > GameManager.Highscores)
        {
            GameManager.Highscores = score;
        }
    }
    public void Chocar()
    {            
        vidas--;

        if (vidas == 0)
        {

            Morir();
            audioSource.PlayOneShot(explosion,0.3f);
        }
        spritesPos++;   
        lives.sprite = livesArray[spritesPos];
    }

    public void GameOver()
    {
        SceneManager.LoadScene(3);
    }
   



}
