using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using random = UnityEngine.Random;

public class DropFruit : MonoBehaviour
{
    [SerializeField] public GameObject[] fruitsPrefabs;
    [SerializeField] public GameObject player;
    private GameObject nextFruit;
    bool isCooldown = false;  

    void Start()
    {
        PrepareNextFruit();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isCooldown)
        {
            StartCoroutine(Cooldown());
            DropCurrentFruit();
            PrepareNextFruit();
        }
    }

    void PrepareNextFruit()
    {
        nextFruit = Instantiate(fruitsPrefabs[random.Range(0, 5)]);
        nextFruit.transform.position = transform.position;
        nextFruit.GetComponent<Rigidbody2D>().isKinematic = true;
        nextFruit.GetComponent<Rigidbody2D>().simulated = false;
        nextFruit.GetComponent<Collider2D>().enabled = false;
        nextFruit.GetComponent<Collider2D>().isTrigger = true;
        nextFruit.transform.SetParent(player.transform);
        nextFruit.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - 0.2f, player.transform.position.z);
    }

    void DropCurrentFruit()
    {
        nextFruit.transform.position = player.transform.position;
        nextFruit.GetComponent<Rigidbody2D>().isKinematic = false;
        nextFruit.GetComponent<Rigidbody2D>().simulated = true;
        nextFruit.GetComponent<Collider2D>().enabled = true;
        nextFruit.GetComponent<Collider2D>().isTrigger = false;
        nextFruit.transform.SetParent(null);
    }

    IEnumerator Cooldown()
    {
        isCooldown = true;
        yield return new WaitForSeconds(0.5f);
        isCooldown = false;
    } 
}
