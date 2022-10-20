using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1;
    
    public float speed;
    public Rigidbody2D rb;

    private void Start()
    {
        rb.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
           Enemy enemy = other.GetComponent<Enemy>();
            //truyen tham so dame vao de tru mau
           enemy.TakeDamage(damage); // Enemy. takedame();

        }
        if (other.gameObject.CompareTag("Enemy2"))
        {
            Enemy2HP enemy = other.GetComponent<Enemy2HP>();
            //truyen tham so dame vao de tru mau
            enemy.TakeDamage(damage); // Enemy. takedame();

        }


    }
}   
