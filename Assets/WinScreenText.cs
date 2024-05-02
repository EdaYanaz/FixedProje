using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenText : MonoBehaviour
{
    public void Bastan()
    {
        SceneManager.LoadScene(1);
    }
    public void Nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Kapat()
    {
        Application.Quit();
    }
    
}
