using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float heath = 10;
    //day la damage tru mau cua 
    public int damage = 1;
    public GameObject addBullet;

    public void Die()
    {
        if (heath == 0)
        {
            Instantiate(addBullet, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    // day la damage truyen vao = 0
    public void TakeDamage(int damage) // 10 = 10 - 5 = 5 +=
    {
        heath -= damage;
        Die();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {

        {
            if (other.gameObject.CompareTag("Player"))
            {
                HpPlayer hp = other.GetComponent<HpPlayer>();
                // day co phai take dam tu player xong tru heath cua pl
                hp.takeDamage(damage); // Enemy. takedame();

            }
        }

    }
}
