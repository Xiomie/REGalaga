using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aliens : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            LevelManager.instance.GameOver();
            gameObject.SetActive(false);
        }
    }
}
