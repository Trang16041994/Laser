using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2HP : MonoBehaviour
{
    public int heath = 5;

    public void Die()
    {
        if(heath == 0)
        {
            Destroy(gameObject);
        }
    }
    public void TakeDamage(int damage)
    {
        heath -= damage;
        Die();
    }
   
}
