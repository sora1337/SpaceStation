using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] Transform firePointRotator;
    [SerializeField] GameObject shotPrefab;
    public float rotateSpeed = 90f;
    public Rigidbody2D rb;
    public float impulsePower = 10f;

    
    public void Shoot()
    {
        Instantiate(shotPrefab, firePoint.position, firePoint.rotation);        
    }

    public void Aim(float input)
    {
        firePointRotator.Rotate(new Vector3 (0, 0, -(input * rotateSpeed * Time.deltaTime)));
    }

    public void Move()
    {
        var movementX = Input.GetAxisRaw("Horizontal");
        var movementY = Input.GetAxisRaw("Vertical");
        if (movementX == 1)
        {
            transform.position += new Vector3(impulsePower, 0, 0);
        }
        if (movementX == -1)
        {
            transform.position += new Vector3(-impulsePower, 0, 0);
        }
        if (movementY == 1)
        {
            transform.position += new Vector3(0, impulsePower, 0);
        }
        if (movementY == -1)
        {
            transform.position += new Vector3(0, -impulsePower, 0);
        }
        
    }
}
