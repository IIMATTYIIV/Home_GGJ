﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject Enemy;
    public float spawnTimer;
    public Transform earth;

    void Start()
    {
        InvokeRepeating("Spawn", spawnTimer, spawnTimer);
    }

    void Spawn()
    {
        SetCoordinates();
        Instantiate(Enemy, Enemy.transform.position, Quaternion.identity);
    }

    void SetCoordinates()
    {
        Enemy.transform.RotateAround(Vector3.zero, Vector3.forward, Random.Range(0, 360));
    }
}
