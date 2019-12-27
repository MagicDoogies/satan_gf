using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTrigger : MonoBehaviour
{
    public CharacterControls Character;
    public GameObject Player;
    public GameObject CatCafe;
    public GameObject Campsite;
    public GameObject Outside;
    public GameObject Room;

    // Start is called before the first frame update
    void Start()
    {
        Character = GameObject.Find("Player").GetComponent<CharacterControls>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (tag == "Cafe")
        {
            CatCafe.SetActive(false);
            Outside.SetActive(true);
        }
        else 
        if (tag == "Campsite")
        {
            Campsite.SetActive(false);
            Outside.SetActive(true);
        }
        else
        if(tag == "YourRoom")
        {
            Room.SetActive(false);
            Outside.SetActive(true);
        }
        print("I'm activating");
        Character.Outside = true;
        Character.OutsideRepo = true;
    }
}
