using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] Player currentPlayer;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            currentPlayer.Shoot();
        }
        
        // if (Input.GetAxisRaw("Horizontal"))
        {
            currentPlayer.Aim(Input.GetAxisRaw("Horizontal"));
        }
    }
}
