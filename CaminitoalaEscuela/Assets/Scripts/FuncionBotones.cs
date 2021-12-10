using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FuncionBotones : MonoBehaviour
{
    public ContLibro ContLibro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void IntertarNuevo(){
        SceneManager.LoadScene("Nivel1");
    }

    public void salir(){
       Application.Quit();
    }
}
