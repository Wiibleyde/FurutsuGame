using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollision : MonoBehaviour
{
    [HideInInspector] public DropFruit DropFruit;
    public int FruitIndex;
    public bool hasbeendroped = false;
    public int ScoreValue;

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
        hasbeendroped = true;
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
                if (FruitIndex < 11)
                {
                    GameObject nextFruit = Instantiate(DropFruit.fruitsPrefabs[FruitIndex]);
                    nextFruit.transform.position = transform.position;
                    Destroy(collidedFruit.gameObject);
                    Destroy(gameObject);
                }
                else
                {
                    Destroy(collidedFruit.gameObject);
                    Destroy(gameObject);
                }
                
                switch (FruitIndex)
                {
                    case 1:
                        ScoreValue = ScoreValue + 1;
                        break;
                    case 2:
                        ScoreValue = ScoreValue + 3;
                        break;
                    case 3:
                        ScoreValue = ScoreValue + 6;
                        break;
                    case 4:
                        ScoreValue = ScoreValue + 10;
                        break;
                    case 5:
                        ScoreValue = ScoreValue + 15;
                        break;
                    case 6:
                        ScoreValue = ScoreValue + 21;
                        break;
                    case 7:
                        ScoreValue = ScoreValue + 28;
                        break;
                    case 8:
                        ScoreValue = ScoreValue + 36;
                        break;
                    case 9:
                        ScoreValue = ScoreValue + 45;
                        break;
                    case 10:
                        ScoreValue = ScoreValue + 55;
                        break;
                    case 11:
                        ScoreValue = ScoreValue + 66;
                        break;
                }
            }
        }
    }
}