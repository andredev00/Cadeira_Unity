using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {

    [SerializeField] Transform Spawn;
   


    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.transform.CompareTag("Player"))
            col.transform.position = Spawn.position;

       Application.LoadLevel(Application.loadedLevel);
        
    }
     

}
