using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneHandler : MonoBehaviour
{
    public CharacterControls Character;
    public GameObject PlayerRoom;
    public GameObject CatCafe;
    public GameObject Campsite;
    public GameObject Outside;
   
    // Start is called before the first frame update
    void Start()
    {
        Character = GameObject.Find("Player").GetComponent<CharacterControls>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Character.Outside == true)//if the outside boolean in Character Controls is true then...
        {//The outside level will become visible and the other levels will become deactivated.
            Outside.SetActive(true);
            PlayerRoom.SetActive(false);
            CatCafe.SetActive(false);
            Campsite.SetActive(false);
        }
    }
}
