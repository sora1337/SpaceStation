using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] Player currentPlayer;

    void Update()
    {
        currentPlayer.Move();
        currentPlayer.Aim(Input.GetAxisRaw("Jump"));
        
        if (Input.GetKeyDown(KeyCode.Keypad1)) currentPlayer.Shoot(0);
        if (Input.GetKeyDown(KeyCode.Keypad2)) currentPlayer.Shoot(1);
        if (Input.GetKeyDown(KeyCode.Keypad3)) currentPlayer.Shoot(2);
    }
}
