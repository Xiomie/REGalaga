using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
 
{  
    public Animator animator;
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("Shoot", true);

        }
        else
            animator.SetBool("Shoot" , false);
    }

}
