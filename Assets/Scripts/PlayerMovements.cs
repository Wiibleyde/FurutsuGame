using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{	
	public float speed = 0;

    // Update is called once per frame
    void Update()
    {
		// Get the horizontal inputs. and limit the position of the player to the screen
		float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		// Get current fruit size and limit the position of the player to the screen
		GameObject currentFruit = transform.GetChild(1).gameObject;
		float currentFruitSize = currentFruit.GetComponent<SpriteRenderer>().bounds.size.x;
		Debug.Log(currentFruitSize);
		transform.position = new Vector3(Mathf.Clamp(transform.position.x + horizontal, -2.5f + currentFruitSize / 50.0f, 2.5f - currentFruitSize / 50.0f), transform.position.y, transform.position.z);
    }
}
