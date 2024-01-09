using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollision : MonoBehaviour
{
    [HideInInspector] public DropFruit DropFruit;
    public int FruitIndex;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruit"))
        {
            FruitCollision collidedFruit = collision.gameObject.GetComponent<FruitCollision>();

            if (collidedFruit.FruitIndex == FruitIndex)
            {
                Debug.Log("Correct fruit");

                GameObject nextFruit = Instantiate(DropFruit.fruitsPrefabs[FruitIndex++]);
                nextFruit.transform.position = transform.position;
                Destroy(collidedFruit.gameObject);
                Destroy(gameObject);

            }
        }
    }
}