using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daymovement : MonoBehaviour {

    public CharacterController2D controller;

    public float runspeed = 90f;

    float horizontalmove = 0f;

    bool jump = false;
    bool crouch = false;
	
	
	// Update is called once per frame
	void Update () {

       horizontalmove = Input.GetAxisRaw("Horizontal") * runspeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if(Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
	}


    private void FixedUpdate()
    {
        // move 
        controller.Move(horizontalmove * Time.fixedDeltaTime, crouch , jump);
        jump = false;

    }

 

}
