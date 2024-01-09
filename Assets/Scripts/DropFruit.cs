using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropFruit : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Drop the fruit when the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Get the position of the player
            Vector3 playerPosition = transform.position;
            // Create a new position for the fruit
            Vector3 fruitPosition = new Vector3(playerPosition.x, playerPosition.y + 0.5f, playerPosition.z);
            // Create a new fruit tagged as "Cherry"
            GameObject fruit = Instantiate(Resources.Load("Cherry"), fruitPosition, Quaternion.identity) as GameObject;
            // Add a force to the fruit
            fruit.GetComponent<Rigidbody>().AddForce(Vector3.up * 100);
        }
    }
}
