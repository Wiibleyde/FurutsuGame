using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropFruit : MonoBehaviour
{
    GameObject fruit;
    // Update is called once per frame
    void Update()
    {
        string[] possibility = { "Cherry", "Strawberry", "Grape", "Persimmons", "Orange" };
        // Drop the fruit when the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space bar pressed");
            // Get the position of the player
            Vector3 playerPosition = transform.position;
            Debug.Log("Player position: " + playerPosition);
            // Create a new position for the fruit
            Vector3 fruitPosition = new Vector3(playerPosition.x, playerPosition.y - 0.5f, playerPosition.z);
            Debug.Log("Fruit position: " + fruitPosition);
            // Create a new fruit randomly from the name of the prefab ("Cherry""Strawberry""Grape""Persimmons""Orange") 
            fruit = Instantiate(Resources.Load(possibility[Random.Range(0, possibility.Length)]) as GameObject, fruitPosition, Quaternion.identity);
            // Add a force to the fruit
            fruit.GetComponent<Rigidbody>().AddForce(Vector3.up * 100);
        }
    }
}
