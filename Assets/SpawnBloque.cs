using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnBloque : MonoBehaviour
{
    [SerializeField] private GameObject Bloqueprefab;
    [SerializeField] private Transform SpawnGrua;
    [SerializeField] private GameObject Bloqueprefab2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            float randomNumber = Random.Range(1, 2);
            switch (randomNumber)
            {
                case 1:
                    Instantiate(Bloqueprefab, SpawnGrua.position, SpawnGrua.rotation);
                    break;
                case 2:
                    Instantiate(Bloqueprefab2, SpawnGrua.position, SpawnGrua.rotation);
                    break;
                default:
                    Instantiate(Bloqueprefab, SpawnGrua.position, SpawnGrua.rotation);
                    break;
            }
            //Instantiate(Bloqueprefab, SpawnGrua.position, SpawnGrua.rotation);
        }

    }
}