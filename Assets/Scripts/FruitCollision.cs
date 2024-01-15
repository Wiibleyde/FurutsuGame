using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollision : MonoBehaviour
{
    [HideInInspector] public DropFruit DropFruit;
    public int FruitIndex;

    void Start()
    {
        if (DropFruit == null)
        {
            DropFruit = FindObjectOfType<DropFruit>();
            
            if (DropFruit == null)
            {
                Debug.LogError("No DropFruit object found in the scene.");
            }
        }
    }

	private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fruit"))
        {
            FruitCollision collidedFruit = collision.gameObject.GetComponent<FruitCollision>();

            if (collidedFruit.FruitIndex == FruitIndex)
            {
                FruitIndex = FruitIndex + 1;

                if (DropFruit == null)
                {
                    Debug.LogError("DropFruit is null");
                    return;
                }

                if (DropFruit.fruitsPrefabs == null || DropFruit.fruitsPrefabs.Length <= FruitIndex)
                {
                    Debug.LogError("fruitsPrefabs is null or does not contain an element at index " + FruitIndex);
                    return;
                }

                GameObject nextFruit = Instantiate(DropFruit.fruitsPrefabs[FruitIndex]);
                nextFruit.transform.position = transform.position;
                Destroy(collidedFruit.gameObject);
                Destroy(gameObject);
            }
        }
    }
}