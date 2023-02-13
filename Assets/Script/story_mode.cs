using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class story_mode : MonoBehaviour
{
    private int count = 0;
    private string[] list_text = {
        "Hay là một hành trình để tìm ra chính mình ?",
        "6 giờ tối , tại một vùng ngoại ô thành phố Hồ Chí Minh...",
        "Trong một ngôi nhà không mấy khang trang..."
        };
    public Text text_element;
    public Text text_element2;
    void Start()
    {
        text_element.text = "Khắc kỷ, là bạn ? là thù ? ";
        text_element2.text = "[Tiếp tục]";
    }
    public void click()
    {
        if (count <= 2)
        {
            text_element.text = list_text[count];
            count++;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
