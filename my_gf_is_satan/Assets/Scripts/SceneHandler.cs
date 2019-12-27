using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneHandler : MonoBehaviour
{
    public CharacterControls Character;
    //These game objects will allow me to activate or deactivate the scenes depeding on what triggers the characters hit.
    public GameObject PlayerRoom;
    public GameObject CatCafe;
    public GameObject Campsite;
    public GameObject Outside;

    public bool InCafe = false;
    public bool InCamp = false;
   
    // Start is called before the first frame update
    void Start()
    {
        //Character = GameObject.Find("Player").GetComponent<CharacterControls>();
    }

    // Update is called once per frame
    void Update()
    {/*
        if (Character.Outside == true)//if the outside boolean in Character Controls is true then...
        {//The outside level will become visible and the other levels will become deactivated.
            Outside.SetActive(true);
            PlayerRoom.SetActive(false);
            CatCafe.SetActive(false);
            Campsite.SetActive(false);
        }
        if(InCafe == true)
        {
            Outside.SetActive(false);
            PlayerRoom.SetActive(false);
            CatCafe.SetActive(true);
            Campsite.SetActive(false);
        }
        if(InCamp == true)
        {
            Outside.SetActive(false);
            PlayerRoom.SetActive(false);
            CatCafe.SetActive(false);
            Campsite.SetActive(true);
        }*/
    }
}
