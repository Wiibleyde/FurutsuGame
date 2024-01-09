using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using random = UnityEngine.Random;

public class DropFruit : MonoBehaviour
{
    [SerializeField] public GameObject[] fruitsPrefabs;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print(fruitsPrefabs);
            GameObject nextFruit = Instantiate(fruitsPrefabs[random.Range(0, 5)]);
            nextFruit.transform.position = transform.position;
        }
    }
}
