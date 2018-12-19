using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform firePoint;
    public Transform firePoint1;
    public GameObject laser;
    public GameObject laser1;

    public float cooldown = 0.5f;
    private bool canShoot = true;

    void Update()
    {
        if (Input.GetButton("Fire1") && canShoot == true)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(laser, firePoint.position, firePoint.rotation);
        Instantiate(laser1, firePoint1.position, firePoint1.rotation);
        StartCoroutine(Cooldown());
    }

    IEnumerator Cooldown()
    {
        canShoot = false;
        yield return new WaitForSeconds(cooldown);
        canShoot = true;
    }
}
