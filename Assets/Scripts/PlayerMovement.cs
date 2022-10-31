using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public LaunchProjectile1 ProjectilePrefab;
    public Transform LaunchOffset;
    public CharacterController controller;
    public float speed = 2.0f;
    private float activeMoveSpeed;
    public float dashSpeed = 3f;
    public float dashLength = .5f, dashCooldown = 1f;

    private float dashCounter;
    private float dashCoolCounter;

        void Start()
    {
        activeMoveSpeed = speed;

    }
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

        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
        }
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (dashCoolCounter <=0 && dashCounter <= 0)
            {
               speed = dashSpeed;
                dashCounter = dashLength;
            }
        }
        if (dashCounter>0)
        {
            dashCounter -= Time.deltaTime;
            if(dashCounter <=0)
            {
                speed = 5f;
                dashCoolCounter = dashCooldown;
            }
        }
        if (dashCoolCounter > 0)
        {
            dashCoolCounter -= Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.E))
        TrailRenderer.FindObjectOfType<TrailRenderer>();
    }

}
