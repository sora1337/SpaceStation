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
            Debug.Log("Shoot 1");
            currentPlayer.Shoot();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            Debug.Log("Shoot 2");
            currentPlayer.Shoot2();
        }

        if (Input.GetButtonDown("Fire3"))
        {
            Debug.Log("Shoot 3");
            currentPlayer.Shoot3();
        }
        
        currentPlayer.Aim(Input.GetAxisRaw("Jump"));
        currentPlayer.Move();
        
    }
}
