using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;

public class SawSpawn : MonoBehaviour
{
    public GameObject SpawnPrefab;
    public float speed = 0.5f;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("Spawner",0,speed);
    }

    public void Spawner()
    {
            Vector3 sawSpawn = transform.position;
            sawSpawn.y = Random.Range(1f, 1.8f);
            Instantiate(SpawnPrefab, sawSpawn, Quaternion.identity);
        
        
    }
}
