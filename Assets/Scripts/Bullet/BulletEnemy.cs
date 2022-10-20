using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    public int damage;
    public int speed;
    public Rigidbody2D rb;
    public GameObject fxEnemy;

    
    private void Start ()
    {
        Move();

        transform.Rotate(0, 0, 0);
    }
    public void Move()
    {
        rb.velocity = transform.right * speed;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            HpPlayer hp = other.GetComponent<HpPlayer>();
            hp.takeDamage(damage);
            Instantiate(fxEnemy, other.transform.position, Quaternion.identity);
            Destroy(gameObject);
               
        }
    }
}
