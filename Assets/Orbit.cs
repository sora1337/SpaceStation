using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{

    public float orbitSpeed;
    public GameObject pivotObject;

    void Update()
    {
        transform.RotateAround(pivotObject.transform.position, new Vector3(0, 0, 10), orbitSpeed * Time.deltaTime);
    }
}
