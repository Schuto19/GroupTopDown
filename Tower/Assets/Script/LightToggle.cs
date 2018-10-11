using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightToggle : MonoBehaviour {

    //Attached to player.
    //Darkness will show in inspector. Attach the
    //corresponding canvas you want to make disappear.
    public GameObject Darkness;

    void OnCollisionEnter2D(Collision2D collision)
        //If player collides with object tagged torch,
        //the smaller FOV canvas is disabled to increase
        //visibilty, and the torch will be destroyed.
    {
        if(collision.gameObject.tag == "Torch")
        {
            Darkness.GetComponent<Canvas>().enabled = false;
            Destroy(collision.gameObject);            
        }
    }
}
