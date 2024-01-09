using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollision : MonoBehaviour
{
    [HideInInspector] public DropFruit DropFruit;
    public int FruitIndex;

	private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fruit"))
        {
            FruitCollision collidedFruit = collision.gameObject.GetComponent<FruitCollision>();

            if (collidedFruit.FruitIndex == FruitIndex)
            {
                Debug.Log("Correct fruit");
				
                GameObject nextFruit = Instantiate(DropFruit.fruitsPrefabs[FruitIndex+1], transform.position, Quaternion.identity);
                nextFruit.transform.position = transform.position;
                Destroy(collidedFruit.gameObject);
                Destroy(gameObject);

            }
        }
    }

	private void Awake()
	{
    	DropFruit = GetComponent<DropFruit>();
    	if (DropFruit == null)
    	{
        	Debug.LogError("Le composant DropFruit n'a pas été trouvé sur le même GameObject ou ses enfants.");
    	}
	}
}