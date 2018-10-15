using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeChase : MonoBehaviour {

    public GameObject player;
    public float chaseSpeed = 3.0f;
    public float chaseTriggerDistance = 3.0f;
    Vector3 startPosition;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 playerPosition = player.transform.position;
        //vector from enemy position to the players position
        Vector3 chaseDirection = playerPosition - transform.position;
        if (chaseDirection.magnitude < chaseTriggerDistance)
        {
            //chase because the player is close to the enemy
            chaseDirection.Normalize();
            GetComponent<Rigidbody2D>().velocity = chaseDirection * chaseSpeed;
        }

    }
}
