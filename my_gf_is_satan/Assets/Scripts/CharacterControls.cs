using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControls : MonoBehaviour
{
    public float MoveSpeed;//control how fast the character moves. 
    public bool Outside = false;//this bool will check to see if the player is "outside".
    public bool OutsideRepo = false;//Controls whether the outside player needs to be initially repositioned.
   
    public Rigidbody2D rb;// A reference holder for the rigibody2D component.
    Vector2 Movement;
   
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Outside== false)
        {
            //Going to give the character WASD movement controls.
            Movement.x = Input.GetAxisRaw("Horizontal");//This specific command is hardwired into the Unity program. It automatically knows that you want to go on the x,y,z axis and moves the object accordingly.
            Movement.y = Input.GetAxisRaw("Vertical");

        }
        else
        if (Outside == true)//Controls where the player is initially located and how they can move when they hit the outside.
        {
            Movement.x = Input.GetAxisRaw("Horizontal");//they can only move on the x axis.
            //transform.position = new Vector2(-6, -3);
            OutdoorReposition();
        }

    }
    public void OutdoorReposition()
    {
        if(OutsideRepo == true)
        {
            transform.position = new Vector2(-6, -3);
            OutsideRepo = false;//boolean ensures the character is only being repositioned once.
        }
      
    }
 
    private void FixedUpdate()//ensures that the physics work correctly no matter what framerate a given computer is operating on.
    {
        rb.MovePosition(rb.position + Movement *MoveSpeed * Time.fixedDeltaTime);
    }
}
