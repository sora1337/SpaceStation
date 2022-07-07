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

        if (Input.GetButtonDown("Fire2"))
        {
            currentPlayer.Shoot2();
        }
        
        currentPlayer.Aim(Input.GetAxisRaw("Jump"));
        currentPlayer.Move();

    }
}
