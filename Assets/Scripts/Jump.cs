using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private SoundManager soundManagerScript;
    private Rigidbody2D rb;
    [SerializeField] private float jumpAmount;
    [SerializeField] private float radius;
    [SerializeField] private Transform feetPos;
    [SerializeField] private LayerMask layermask;
   
    private void Start()
    {
        soundManagerScript = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
        rb = GetComponent<Rigidbody2D>();
    }

    
    private void Update()
    {
        if(Input.GetButtonDown("Jump")&& IsGrounded())
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            soundManagerScript.Jump();
        }
    }

    bool IsGrounded()
    {
        return Physics2D.OverlapCircle(feetPos.position, radius,layermask);
    }
}
