using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 1;
    public EnemyShoot ProjectilePrefab;
    public Transform LaunchOffset;
    private int shoot;

    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y - (speed * Time.deltaTime));

        shoot = Random.Range(0, 200);
        Debug.Log(shoot);

        if (shoot == 49)
        {
            Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Destroy(collision.gameObject);
        }
    }
}
