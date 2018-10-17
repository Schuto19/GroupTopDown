using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashSword : MonoBehaviour {

    public GameObject prefab;
    float timer = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1") && timer > 0.1f)
        {
         var mousePosition = Input.mousePosition;
         mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
         mousePosition.z = 0;
         GameObject sword = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
         Destroy(sword, 1.0f);
        }
    }
}
