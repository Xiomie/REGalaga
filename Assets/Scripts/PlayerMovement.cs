using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 2.0f;
    void Update()
    {
        Vector3 currentpos = transform.position;
        Vector3 motion = Vector3.zero;

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
     


        currentpos.x = currentpos.x + speed * inputX * Time.deltaTime;

   
        currentpos.y = currentpos.y + speed * inputY * Time.deltaTime;

        


        motion = (transform.up * speed * inputY * Time.deltaTime)
            + (transform.right * speed * inputX * Time.deltaTime);

        controller.Move(motion);
    }
}
