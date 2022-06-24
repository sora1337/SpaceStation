using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] Transform firePointRotator;
    [SerializeField] GameObject shotPrefab;

    
    public void Shoot()
    {
        Instantiate(shotPrefab, firePoint.position, firePoint.rotation);
    }

    public void Aim(float input)
    {
        //rotator guy
    }
}
