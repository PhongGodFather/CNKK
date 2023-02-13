using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_movement : MonoBehaviour
{
    public bool isMove = true;
    public float speed;
    public int Scene_index;
    public Rigidbody2D rb;
    Vector2 move_direction;
    public SpriteRenderer Rotate;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isMove == true)
        {
            move_direction.x = Input.GetAxisRaw("Horizontal");
            move_direction.y = Input.GetAxisRaw("Vertical");
            if (Mathf.Abs(move_direction.x * speed) >= 0.07)
                anim.SetFloat("is_run", Mathf.Abs(move_direction.x * speed));
            else
                anim.SetFloat("is_run", 0f);
            if (Mathf.Abs(move_direction.y * speed) >= 0.07)
                anim.SetFloat("is_run", Mathf.Abs(move_direction.y * speed));
            /*if (Input.GetMouseButtonDown(0))
                anim.SetBool("is_attack", true);
            else
                anim.SetBool("is_attack", false);
            if (Input.GetMouseButtonDown(1))
                anim.SetBool("is_attack2", true);
            else
                anim.SetBool("is_attack2", false);*/
        }
    }
    void FixedUpdate()
    {
        if (isMove == true)
        {
            if (move_direction.x == -1)
                Rotate.flipX = true;
            if (move_direction.x == 1)
                Rotate.flipX = false;
            if (move_direction.x != 0 || move_direction.y != 0)
            {
                if (move_direction.x != 0 && move_direction.y != 0)
                {
                    move_direction.x *= 0.7f;
                    move_direction.y *= 0.7f;
                }
                rb.velocity = new Vector2(move_direction.x * speed, move_direction.y * speed);
            }
            else
            {
                rb.velocity = new Vector2(0f, 0f);
            }
        }
        Scene_index = SceneManager.GetActiveScene().buildIndex;
    }

    public void Save_game()
    {
        SaveLoadSystem.Save(this);
    }
}
