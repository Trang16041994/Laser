using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPlayer : MonoBehaviour
{
    public int heath = 10;
    public int damage = 1;

    public void takeDamage(int damageDown)
    {
        heath -= damageDown;
        Die();

    }
    public void Die()
    {
        if (heath == 0)
        {
            Destroy(gameObject);
        }
            
    }
    
 
}
