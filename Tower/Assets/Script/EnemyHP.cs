using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour {

    public int HP = 1;
    public GameObject prefab;
    public GameObject prefab2;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            HP--;
            if(HP <= 0)
            {
                Destroy(gameObject);
                GameObject Heart = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
                GameObject MpStar = (GameObject)Instantiate(prefab2, transform.position, Quaternion.identity);
            }
        }
    }
}
