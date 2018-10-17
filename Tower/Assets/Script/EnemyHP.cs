﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour {

    public int HP = 1;
    public GameObject prefab;
    public GameObject prefab2;
    int R;
    private void Start()
    {
        R = Random.Range(0, 4); 
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            HP--;
            if (collision.gameObject.tag == "Sword")
            {
                HP += 5;
            }
            if(HP <= 0)
            {
                Destroy(gameObject);
                if (R == 2)
                {
                    GameObject Heart = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
                }
                else if (R == 1 || R == 0)
                { 
                    GameObject MpStar = (GameObject)Instantiate(prefab2, transform.position, Quaternion.identity);
                }
                
            }
        }
    }
}
