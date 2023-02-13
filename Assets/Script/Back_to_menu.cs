using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Back_to_menu : MonoBehaviour
{
    private int count = 0;
    public Text paragraph;
    public Text clicktocontinue;
    public GameObject button;
    public GameObject escape_button;
    public GameObject save_button;
    public Player_movement player;
    private string[] list_text = {
        "đang là lúc nào vậy ? ...",
        "Dùng W,A,S,D để di chuyển ",
        "hmm... bây giờ là thế nào đây ?",
        "à phải rồi, một thằng nhân viên vô vọng bị đuổi việc, vợ con xa lánh ",
        "haizz, ảo thật đấy..."
    };
    void Start()
    {
        escape_button.SetActive(false);
        save_button.SetActive(false);
        player.isMove = false;
        paragraph.text = "urgh....";
        clicktocontinue.text = "[Tiếp tục]";
    }
    public static void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void click_for_story()
    {
        if (count <= 4)
        {
            if (count >= 1)
                player.isMove = true;
            paragraph.text = list_text[count];
            count++;
        }
        else
        {
            escape_button.SetActive(true);
            save_button.SetActive(true);
            button.SetActive(false);
        }
    }
}
