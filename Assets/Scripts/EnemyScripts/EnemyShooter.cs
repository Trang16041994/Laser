using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyShooter : MonoBehaviour
{
    public Transform point;
    public GameObject bullet;
    public float attackSpeed;
    public float nextAttackSpeed;

    private void Update()
    {
        Shoot();
    }
    void Shoot()
    {
        if( Time.time >= nextAttackSpeed)
        {
            Instantiate(bullet, point.position,point.rotation );
            nextAttackSpeed = Time.time + 1f / attackSpeed;
        }
    }

    
                
            
}
