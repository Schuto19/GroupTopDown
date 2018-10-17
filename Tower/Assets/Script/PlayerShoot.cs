using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour {

    public GameObject prefab;
    public float shootSpeed = 10;
    float timer = 0;
    public int Mp = 10;
    public Text MpText;
    public Slider MpBar;

    // Use this for initialization
    void Start () {
        MpText.GetComponent<Text>().text = "MP: " + Mp;
        MpBar.GetComponent<Slider>().value = Mp;
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (Input.GetButton("Fire2") && timer > 0.5f && Mp > 0)
        {
            Mp--;
            MpBar.GetComponent<Slider>().value = Mp;
            MpText.GetComponent<Text>().text = "MP: " + Mp;
            timer = 0;
            var mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition.z = 0;
            Vector3 shootDir = mousePosition - transform.position;
            shootDir.Normalize();
            shootDir = shootDir * shootSpeed;
            //when calculating a vector from a to b always do destination - start position
            GameObject bullet = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir;
            Destroy(bullet, 1.0f);
            
        }
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MpStar")
        {
            Mp++;
            MpBar.GetComponent<Slider>().value = Mp;
            MpText.GetComponent<Text>().text = "MP: " + Mp;
            Destroy(collision.gameObject);
        }
    }
}
