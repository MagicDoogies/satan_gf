using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed;//control how fast the character moves. 
    public bool Outside = false;//this bool will check to see if the player is "outside".

    public Rigidbody2D rb;// A reference holder for the rigibody2D component.
    Vector2 Movement;
    
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //Going to give the character WASD movement controls.
       Movement.x= Input.GetAxisRaw("Horizontal");//This specific command is hardwired into the Unity program. It automatically knows that you want to go on the x,y,z axis and moves the object accordingly.
       Movement.y = Input.GetAxisRaw("Vertical");
        
        if(Outside == true)//If the player is in the outside area they can only move along the horizontal axis.
        {
            Movement.x = Input.GetAxisRaw("Horizontal");
        }

    }
    private void FixedUpdate()//ensures that the physics work correctly no matter what framerate a given computer is operating on.
    {
        rb.MovePosition(rb.position + Movement *MoveSpeed * Time.fixedDeltaTime);
    }
}
