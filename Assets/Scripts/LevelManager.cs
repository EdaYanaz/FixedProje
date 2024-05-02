using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private Transform playerSpawnPos;
    [SerializeField] private GameObject trashPrefab;
    private SoundManager soundManagerScript;
   
    public int count;
    public bool trashBool;
    public bool canWin;
    private void Awake()
    {
        soundManagerScript = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
        
    }
    private void Start()
    {
        SpawnPlayer();
        SpawnTrash();
    }
    private void Update()
    {
        if(trashBool)
        {
            StartCoroutine(DelayTrash());
            trashBool = false;
        }
    }
    private void SpawnPlayer()
    {
        Instantiate(playerPrefab, playerSpawnPos.position, Quaternion.identity);
    }

    public void ReSpawnPlayer()
    {
        Instantiate(playerPrefab, playerSpawnPos.position, Quaternion.identity);
    }

    public void SpawnTrash()
    {
        Vector3 firstPos = new Vector3(Random.Range(-8.18f, 8.18f), -3.69f, 0);
        Vector3 secondPos = new Vector3(Random.Range(-5.42f, 5.42f), 2.47f, 0);

        int randomSpawner = Random.Range(1, 3);
       

        if (randomSpawner == 1)
        {
            Instantiate(trashPrefab, firstPos, Quaternion.identity);
        }
        if (randomSpawner == 2)
        {
            Instantiate(trashPrefab, secondPos, Quaternion.identity);
        }
        
    }

    IEnumerator DelayTrash()
    {
        if(count==5)
        {
            canWin = true;
            
        }
        yield return new WaitForSeconds(1.5f);
        if(count<5)
        {
            SpawnTrash();
            soundManagerScript.PopTrash();

        }
    }
}
