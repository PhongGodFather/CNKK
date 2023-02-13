using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
public class SaveLoadSystem : MonoBehaviour
{
    public static void Save(Player_movement player)
    {
        PlayerData temp = new PlayerData(player);
        BinaryFormatter nice = new BinaryFormatter();
        FileStream file = new FileStream(Application.persistentDataPath + "/playerSave.txt", FileMode.Create);
        nice.Serialize(file, temp);
        file.Close();
    }

    public static PlayerData LoadPlayer()
    {
        if (File.Exists(Application.persistentDataPath + "/playerSave.txt"))
        {
            BinaryFormatter nice = new BinaryFormatter();
            FileStream file = new FileStream(Application.persistentDataPath + "/playerSave.txt", FileMode.Open);
            PlayerData data = nice.Deserialize(file) as PlayerData;
            file.Close();
            return data;
        }
        else
            return null;
    }
}
