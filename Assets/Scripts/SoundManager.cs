using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip jump;
    [SerializeField] private AudioClip land;
    [SerializeField] private AudioClip deathByEnemy;
    [SerializeField] private AudioClip deathByFall;
    [SerializeField] private AudioClip enemyAttack;
    [SerializeField] private AudioClip popTrash;
    [SerializeField] private AudioClip destroyTrash;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Jump()
    {
        audioSource.PlayOneShot(jump);
    }
    public void Land()
    {
        audioSource.PlayOneShot(land);
    }
    public void DeathByEnemy()
    {
        audioSource.PlayOneShot(deathByEnemy);
    }
    public void DeathByFall()
    {
        audioSource.PlayOneShot(deathByFall);
    }
    public void EnemyAttack()
    {
        audioSource.PlayOneShot(enemyAttack);
    }
    public void PopTrash()
    {
        audioSource.PlayOneShot(popTrash);
    }
    public void DestroyTrash()
    {
        audioSource.PlayOneShot(destroyTrash);
    }
}

