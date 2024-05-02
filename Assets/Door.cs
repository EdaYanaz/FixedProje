using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
{
    private LevelManager levelManagerScript;
    private WinScreenText winScreenTextScript;
   
    private void Awake()
    {
        levelManagerScript = GameObject.Find("Level Manager").GetComponent<LevelManager>();
        winScreenTextScript = GameObject.Find("Win Screen Canvas").GetComponent<WinScreenText>();
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")&& levelManagerScript.canWin)
        {
            winScreenTextScript.GetComponent<Canvas>().enabled = true;
            
        }
    }
}
