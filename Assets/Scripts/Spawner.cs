using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] bulletPatterns;
    private float spawnTime;
    public float spawnPeriod;

    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
        if (spawnTime <= 0)
        {
            int rand = Random.Range(0, bulletPatterns.Length);
            Instantiate(bulletPatterns[rand], transform.position,Quaternion.identity);
            spawnTime = spawnPeriod;
        }
        else
        {
            spawnTime -= Time.deltaTime;
        }
        
    }
}
