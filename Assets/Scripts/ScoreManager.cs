using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int ScoreValue = 0;
    // Update is called once per frame
    void UpdateScore(int value)
    {
        ScoreValue = ScoreValue + value;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UpdateScore(1);
        }
    }
}
