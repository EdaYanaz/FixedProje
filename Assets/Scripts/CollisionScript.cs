using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    private SoundManager soundManagerScript;
    private LevelManager levelManagerScript;

    private UIManager UIManagerScript;
    bool isAttacking;

    private void Awake()
    {
        soundManagerScript = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
        levelManagerScript = GameObject.Find("Level Manager").GetComponent<LevelManager>();
        UIManagerScript = GameObject.Find("UI Manager").GetComponent<UIManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
           
            Destroy(collision.gameObject);
            levelManagerScript.ReSpawnPlayer();
            soundManagerScript.DeathByEnemy();
            UIManagerScript.GetComponent<Canvas>().enabled = true;

        }
    }

    private void FixedUpdate()
    {
        AttackEnemy();
        DestroyEnemy();
    }

    private void AttackEnemy()
    {
        transform.Translate(-1 * 20 * Time.deltaTime, 0, 0);
        while (!isAttacking)
        {
            soundManagerScript.EnemyAttack();
            isAttacking = true;
        }
    }
    private void DestroyEnemy()
    {
        if(transform.position.x<-11)
        {
            Destroy(gameObject);
        }
    }
}
