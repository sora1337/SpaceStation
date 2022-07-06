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

        currentPlayer.Aim(Input.GetAxisRaw("Fire2"));
        currentPlayer.Move();

    }
}
