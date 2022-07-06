using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{

    public Rigidbody2D rb;

    void FixedUpdate() 
    {
        Attractor[] attractors = FindObjectsOfType<Attractor>();
        foreach (Attractor attractor in attractors)
        {
            if (attractor != this)
            {
                Attract(attractor);
            }
        }
    }

    void Attract (Attractor ObjectToAttract)
    {
        Rigidbody2D rbToAttract = ObjectToAttract.rb;

        Vector2 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;

        float forceMagnitude = (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
        Vector2 force = direction.normalized * forceMagnitude;

        rbToAttract.AddForce(force);
    }
}
