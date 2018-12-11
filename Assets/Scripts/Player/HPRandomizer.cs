using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPRandomizer : MonoBehaviour
{

    public GameObject RandomHp;
    public float spotX;
    public float spotY = 1;
    public float spotZ;

    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        spotX = Random.Range(-30, 30);
        spotZ = Random.Range(-25, 15);
        RandomHp.transform.position = new Vector3(spotX, spotY, spotZ);
    }
    public void SpawnObject()
    {
        Instantiate(RandomHp, transform.position, transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}