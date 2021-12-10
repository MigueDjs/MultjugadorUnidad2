using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;


public class LogicaJuego : NetworkBehaviour
{
   
   /* public float velocidad = 3f;
    Rigidbody2D rgb;
    //public float velocidad = 7f;
  void Start() {
        rgb = GetComponent<Rigidbody2D>();
  } 
      
  void Update() {
      if(Input.GetKey(KeyCode.LeftArrow)){
          transform.position += Vector3.left * velocidad * Time.deltaTime;
      }
      if(Input.GetKey(KeyCode.RightArrow)){
          transform.position += Vector3.right * velocidad * Time.deltaTime;
      }
      if(Input.GetKey(KeyCode.UpArrow)){
          transform.position += Vector3.up * velocidad * Time.deltaTime;
      }
      if(Input.GetKey(KeyCode.DownArrow)){
          transform.position += Vector3.down * velocidad * Time.deltaTime;
      }
  }  */
  public static LogicaJuego sharedInstance;
  public float velocidad;
  public float fuerzaSalto;
  public float posX;
  public Rigidbody2D rb;


  void Start() {
      
  }

    
  void Update(){
      if(isLocalPlayer){
      posX = Input.GetAxis("Horizontal");
      transform.position += (Vector3)new Vector2(posX * velocidad * Time.deltaTime, 0f);

      if(Input.GetKeyDown(KeyCode.Space)){
          rb.AddForce(transform.up * fuerzaSalto, ForceMode2D.Impulse);
      }
  }
  
  }


 
}
