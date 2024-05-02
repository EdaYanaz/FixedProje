using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private SoundManager soundManagerScript;
    private LevelManager levelManagerScript;
    private UIManager UIManagerScript;
   
    private Rigidbody2D rb;
    private float horizontalMove;
    [SerializeField] private float playerSpeed = 10f;
    SpriteRenderer playerRenderer;
   
    private void Start()
    {
        levelManagerScript = GameObject.Find("Level Manager").GetComponent<LevelManager>();
        soundManagerScript = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
        UIManagerScript = GameObject.Find("UI Manager").GetComponent<UIManager>();
        rb = GetComponent<Rigidbody2D>();
        playerRenderer = GetComponent<SpriteRenderer>();
        
    }

    private void FixedUpdate()
    {
        PlayerMovement();
        FlipWithRenderer();
        PlayerDead();
    }
    private void PlayerMovement()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalMove * playerSpeed, rb.velocity.y);
    }
    private void FlipWithRenderer()
    {
        if (horizontalMove > 0)
        {
            playerRenderer.flipX = false;

        }
        if (horizontalMove < 0)
        {
            playerRenderer.flipX = true;
        }
    }

    private void PlayerDead()
    {
        if(transform.position.y<-6)
        {
            
            Destroy(gameObject);
            levelManagerScript.ReSpawnPlayer();
            soundManagerScript.DeathByFall();
            



        }
    }
}
