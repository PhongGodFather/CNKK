using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Menu : MonoBehaviour
{
    public int Scene_index;
    void Start() //we gonna read file the player scene position to load it or start a new game and change the Button text as well
    {
        if (File.Exists(Application.persistentDataPath + "/playerSave.txt"))
        {
            PlayerData data = SaveLoadSystem.LoadPlayer();
            if (data == null)
                Scene_index = 0;
            else
                Scene_index = data.Scene_index;
        }
    }
    public void Play()
    {
        SceneManager.LoadScene("Intro");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Continue()
    {
        SceneManager.LoadScene(2);
        /*if (Scene_index != 0)
            SceneManager.LoadScene(Scene_index);
        else
            SceneManager.LoadScene("Intro");*/
    }
}
