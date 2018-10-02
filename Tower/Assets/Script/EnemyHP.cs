using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour {

    public int HP = 1;

        private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            HP--;
            if(HP <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
