using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform pointLeft;
    public Transform pointRight;

    public GameObject bullet;
    public int point;

    void Start()
    {

    }
    public void Update()
    {
        Shoot();
    }
    public void Shoot()
    {
        if(point >= 1)
        {
            Shoot2();
        }
        else
        {
            Shoot1();
        }
    }

    private void Shoot1()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            Instantiate(bullet, pointLeft.position, pointLeft.rotation);
    }

    void Shoot2()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet, pointLeft.position, pointLeft.rotation);
            Instantiate(bullet, pointRight.position, pointRight.rotation);
        }

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AddBullet"))
        {
            point++; 
        }
    }


}

