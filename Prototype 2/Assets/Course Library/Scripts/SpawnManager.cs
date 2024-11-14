using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 2, 2);
    }

    // Update is called once per frame
    void SpawnAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float xPosition = Random.Range(-15, 15);
        Instantiate(animalPrefabs[animalIndex], new(xPosition, 0, 20), animalPrefabs[animalIndex].transform.rotation);
    }
}
