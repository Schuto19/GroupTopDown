using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerHP : MonoBehaviour {
    public int hp = 10;
    public Text hpText;
    public Slider HpBar;
    
    void Start()
    {
        hpText.GetComponent<Text>().text = "HP: " + hp;
        HpBar.GetComponent<Slider>().value = hp;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            hp--;
            HpBar.GetComponent<Slider>().value = hp;
            hpText.GetComponent<Text>().text = "HP: " + hp;
            if (hp <= 0)
            {
                SceneManager.LoadScene("lose");
            }
        }
    }
}
