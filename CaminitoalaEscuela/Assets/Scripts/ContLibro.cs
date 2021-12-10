using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Mirror;

public class ContLibro : NetworkBehaviour
{
    public int score;
    public Text scoreText;

    //public GameObject camaraGameover;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GameObject.Find("TextLibro").GetComponent<Text>();

    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Libro"){
            score++;
            scoreText.text = "Libros: " + score;
        }
        
        if(collision.gameObject.tag == "Meta"){
            //Debug.Log("Felicidades ganaste, llegaste al edificio F");
            SceneManager.LoadScene("GameOver");
            //camaraGameover.SetActive(true);
        }
    

    }
}
