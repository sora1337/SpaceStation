using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public Collider2D hitCollider;
    public float colliderWaitTime;
    public int bulletPower = 20;
    private GameObject currentPortal;

    void Start()
    {
        rb.velocity = transform.up * speed;
        StartCoroutine(EnableColliderRoutine());
    }

    void Update() 
    {
        if (currentPortal != null)
        {
            transform.position = currentPortal.GetComponent<Portal>().GetDestination().position;
        }
    }

    IEnumerator EnableColliderRoutine()
    {
        yield return new WaitForSeconds(colliderWaitTime);
        hitCollider.enabled = true;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Player station = hitInfo.GetComponent<Player>();
        if (station != null)
        {
            station.TakeDamage(bulletPower);
        }
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D (Collider collision) 
    {
        if (collision.CompareTag("Wormhole"))
        {
            currentPortal = collision.gameObject;
        }
    }

    /*private void OnTriggerExit2D(Collider collision) 
    {
        if (collision.CompareTag("Wormhole"))
        {
            if (collision.gameObject == currentPortal)
            {
                currentPortal = null;
            }
        }
    }*/
    
}
