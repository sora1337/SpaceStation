using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 20f;
    public int power = 20;

    //private GameObject currentPortal;


    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player station = hitInfo.GetComponent<Player>();
        if (station != null)
        {
            station.TakeDamage(power);
        }
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
    

    // void Update() 
    // {
    //     if (currentPortal != null)
    //     {
    //         transform.position = currentPortal.GetComponent<Portal>().GetDestination().position;
    //     }
    // }

    // private void OnTriggerEnter2D (Collider collision) 
    // {
    //     if (collision.CompareTag("Wormhole"))
    //     {
    //         currentPortal = collision.gameObject;
    //     }
    // }

    // private void OnTriggerExit2D(Collider collision) 
    // {
    //     if (collision.CompareTag("Wormhole"))
    //     {
    //         if (collision.gameObject == currentPortal)
    //         {
    //             currentPortal = null;
    //         }
    //     }
    // }
}
