using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryTrigger : MonoBehaviour
{
    public CharacterControls Character;
    public GameObject Player;
    //public SceneHandler Scene;
    public GameObject CatCafe;
    public GameObject Campsite;
    public GameObject Outside;
    public GameObject Room;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (tag == "Cafe")
        {
            CatCafe.SetActive(true);
            Outside.SetActive(false);
            Character.Outside = false;
            Character.OutsideRepo = false;
        }
        else 
        if (tag == "Campsite")
        {
            Campsite.SetActive(true);
            Outside.SetActive(false);
            Character.Outside = false;
            Character.OutsideRepo = false;
        }
    }
}
