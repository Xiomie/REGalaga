using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDelete : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            Destroy(other.gameObject);
        }
    }
}
