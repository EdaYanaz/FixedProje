using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    private LevelManager levelManagerScript;
    private SoundManager soundManagerScript;
    private void Awake()
    {
        levelManagerScript = GameObject.Find("Level Manager").GetComponent<LevelManager>();
        soundManagerScript = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            levelManagerScript.trashBool = true;
            soundManagerScript.DestroyTrash();
            levelManagerScript.count++;
            ScoreManager.instance.AddPoint();

        }
      
    }
}
