using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {

    public int index;
    public string levelName;
    public bool estado;
    public GamerController GC;
    public 


    void Start() {
        estado = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player") && estado)
        {
            //Loading level with build index
            GC.addpoint (10.0f);
            SceneManager.LoadScene(index);
              
            
            //Loading Level with scene name
            //SceneManager.LoadScene(levelName);
            

            //Restart 1v1
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
    public void MudaEstado(bool modo) {
        estado = modo;

    }

}
