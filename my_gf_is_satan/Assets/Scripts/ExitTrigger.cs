using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTrigger : MonoBehaviour
{
    public CharacterControls Character;
    public GameObject Player;

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
        Character.Outside = true;
        Character.OutsideRepo = true;
    }
}
