using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject CoinPrefab;
    private float spawnTime;
    private float spawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        spawnTime = 1;
        spawnDelay = Random.Range(1, 10);
        InvokeRepeating("SpawnCoin", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCoin()
    {
        Instantiate(CoinPrefab, transform.position, transform.rotation);
    }
}
