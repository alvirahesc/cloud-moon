using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;
    
    [SerializeField] private float MoveSpeed = 5;
    [SerializeField] private AudioSource footstep_normal;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("running", true);

            rb.velocity = new Vector2(-MoveSpeed,0);
            sprite.flipX = false;
                       
          
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {

            anim.SetBool("running", true);

            rb.velocity = new Vector2(MoveSpeed, 0);
            sprite.flipX = true;
                        
        }

        else
             anim.SetBool("running", false);

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }
    }

    private void Footstep()
    {
        footstep_normal.Play();
    }
}
