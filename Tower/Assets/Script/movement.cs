using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float speed = 3.0f;
    public float dashSpeed = 5.0f;
    float timer = 0.2f;
    public float StartSpeed = 3.0f;

    // Update is called once per frame
    void Update () {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 velocity = new Vector2(x, y);
        GetComponent<Rigidbody2D>().velocity = velocity * speed ;
        if (Input.GetKeyDown(KeyCode.Space) && timer > 0.2f)
        {
            timer = 0;

        }
        if (timer < 0.5f)
        {
            //increase speed
            
            
        }
        else
        {
            //reset speed
        }
    }
}
