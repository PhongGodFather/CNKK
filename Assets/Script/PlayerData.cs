using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //  Activate Serialization
public class PlayerData : MonoBehaviour
{
    public int Scene_index;
    public PlayerData(Player_movement player) // constructor
    {
        Scene_index = player.Scene_index;
    }
}
