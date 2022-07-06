using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] Transform firePointRotator;
    [SerializeField] GameObject shotPrefab;
    public float rotateSpeed = 90f;

    
    public void Shoot()
    {
        Instantiate(shotPrefab, firePoint.position, firePoint.rotation);        
    }

    public void Aim(float input)
    {
        firePointRotator.Rotate(new Vector3 (0, 0, -(input * rotateSpeed * Time.deltaTime)));
    }
}