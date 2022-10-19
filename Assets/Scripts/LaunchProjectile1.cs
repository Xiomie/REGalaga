using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile1 : MonoBehaviour
{
    public float Speed = 4.5f;

    void Update()
    {
        transform.position += transform.up * Time.deltaTime * Speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
