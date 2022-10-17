using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform shooting;
    public float shootSpeed = 20f;
    public float shootTime = 0;
    void Start()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    // Update is called once per frame
    void shoot()
    {
        
    }
}
