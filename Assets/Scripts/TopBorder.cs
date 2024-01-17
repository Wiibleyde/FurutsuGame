using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TopBorder : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruit"))
        {
            FruitCollision fruitdrop = collision.gameObject.GetComponent<FruitCollision>();

            if (fruitdrop.hasbeendroped)
            {
                Debug.Log("Game Over");
                // Reset the game
                SceneManager.LoadScene(0);
                
            }
        }
    }
}
