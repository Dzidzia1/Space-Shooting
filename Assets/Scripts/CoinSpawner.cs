using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public float TimeBetweenSpawns;
    public GameObject prefab;

    private float TimeToNextSpawn;

    void Start()
    {
        TimeToNextSpawn = TimeBetweenSpawns;
    }
    
    void Spawn()
    {
        for(int i=0; i<2; i++)
        Instantiate(prefab,new Vector2(-2+ 7f*i, 10),Quaternion.identity);
    }

    void Update()
    {
        TimeToNextSpawn -= Time.deltaTime;
        if(TimeToNextSpawn<0.0f)
        {
            Spawn();
            TimeToNextSpawn = TimeBetweenSpawns;
        }
    }
}