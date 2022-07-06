using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public Collider2D hitCollider;
    public float colliderWaitTime;

    void Start()
    {
        rb.velocity = transform.up * speed;
        StartCoroutine(EnableColliderRoutine());
    }

    IEnumerator EnableColliderRoutine()
    {
        yield return new WaitForSeconds(colliderWaitTime);
        hitCollider.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
}
