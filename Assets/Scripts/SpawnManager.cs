using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Chomper;

    private float spawnRangeX = -11;// fix range and other bonds for bird
    private float spawnPosY = 15;

    private float startDelay = 2;
    private float spawnInterval = 5f;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnChomp", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnChomp()
    {
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, 0);
        Instantiate(Chomper, spawnpos, transform.rotation);
    }
}
