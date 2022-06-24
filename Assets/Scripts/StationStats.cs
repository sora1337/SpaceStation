using UnityEngine;

public abstract class StationStats : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Destroy");
    }


}

