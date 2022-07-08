using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] Transform firePointRotator;
    [SerializeField] GameObject shotPrefab;
    [SerializeField] GameObject laserPrefab;
    public float rotateSpeed = 90f;
    public float impulsePower = 10f;
    public int maxHealth = 100;
    public int currentHealth = 100;

    public HealthBar healthBar;

    private void Start() 
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    public void Shoot()
    {
        Instantiate(shotPrefab, firePoint.position, firePoint.rotation);        
    }

    public void Shoot2()
    {
        //for (int i = 0; i < 10; i++)
        {
            Instantiate(laserPrefab, firePoint.position, firePoint.rotation);
        }
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
