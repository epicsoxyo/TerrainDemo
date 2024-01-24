using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCine : MonoBehaviour
{
    // create a gameobject to store the player
    public GameObject player; 

    // Awake() happens before ANYTHING else, including Start()
    void Awake()
    {
        // disable the player so they can't move
        player.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown("space")) EndCinematic();
    }

    // Public methods can be linked to triggers in the inspector
    // window. This one ends the cinematic by giving control of the player.
    public void EndCinematic()
    {
        // set our player to active so they can move
        player.SetActive(true);
        // delete the fly through camera as we dont need it anymore
        Destroy(this.gameObject);
     }

}
